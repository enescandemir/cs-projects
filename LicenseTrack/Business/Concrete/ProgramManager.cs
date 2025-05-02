using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class ProgramManager : IProgramService
    {
        private readonly IProgramDal _programDal;

        public ProgramManager(IProgramDal programDal)
        {
            _programDal = programDal;
        }

        public void Add(Program program)
        {
            ValidateProgram(program);

            var existing = _programDal.Get(p => p.Name.ToLower() == program.Name.ToLower());
            if (existing != null)
            {
                throw new Exception("Bu isimde bir program zaten mevcut.");
            }

            _programDal.Add(program);
            Console.WriteLine("Program başarıyla eklendi.");
        }

        public void Update(Program program)
        {
            ValidateProgram(program);
            var existing = _programDal.Get(p => p.Name.ToLower() == program.Name.ToLower() && p.ProgramID != program.ProgramID);
            if (existing != null)
            {
                throw new Exception("Bu isimde başka bir program zaten mevcut.");
            }

            _programDal.Update(program);
        }


        public void Delete(Program program)
        {
            _programDal.Delete(program);
        }

        public List<Program> GetAll()
        {
            return _programDal.GetAll();
        }

        public List<Program> GetByProgramId(int programId)
        {
            return _programDal.GetAll(p => p.ProgramID == programId);
        }

        private void ValidateProgram(Program program)
        {
            var validator = new ProgramValidator();
            var result = validator.Validate(program);

            if (!result.IsValid)
            {
                var errorMessages = string.Join("\n", result.Errors.Select(e => e.ErrorMessage));
                throw new ValidationException(errorMessages);
            }
        }
    }
}
