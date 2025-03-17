using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProgramManager : IProgramService
    {
        public IProgramDal _programDal;
        public ProgramManager(IProgramDal programDal)
        {
            _programDal = programDal;
        }
        public void Add(Program program)
        {
            try
            {
                _programDal.Add(program);
                Console.WriteLine("Program bilgileri başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Program bilgileri eklenirken bir hata oluştu.");
            }
        }

        public void Update(Program program)
        {
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
    }
}
