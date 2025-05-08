using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class VersionManager : IVersionService
    {
        private readonly IVersionDal _versionDal;

        public VersionManager(IVersionDal versionDal)
        {
            _versionDal = versionDal;
        }

        public void Add(Entities.Concrete.Version version)
        {
            ValidateVersion(version);

            var existing = _versionDal.Get(v => v.Name.ToLower() == version.Name.ToLower());
            if (existing != null)
            {
                throw new Exception("Bu isimde bir versiyon zaten mevcut.");
            }

            _versionDal.Add(version);
            Console.WriteLine("Versiyon bilgileri başarıyla eklendi.");
        }

        public void Update(Entities.Concrete.Version version)
        {
            ValidateVersion(version);
            var existing = _versionDal.Get(v => v.Name.ToLower() == version.Name.ToLower() && v.VersionID != version.VersionID);
            if (existing != null)
            {
                throw new Exception("Bu isimde başka bir versiyon zaten mevcut.");
            }

            _versionDal.Update(version);
        }

        public void Delete(Entities.Concrete.Version version)
        {
            _versionDal.Delete(version);
        }

        public List<Entities.Concrete.Version> GetAll()
        {
            return _versionDal.GetAll();
        }

        public List<Entities.Concrete.Version> GetByVersionId(int versionId)
        {
            return _versionDal.GetAll(v => v.VersionID == versionId);
        }

        private void ValidateVersion(Entities.Concrete.Version version)
        {
            var validator = new VersionValidator();
            var result = validator.Validate(version);

            if (!result.IsValid)
            {
                var errorMessages = string.Join("\n", result.Errors.Select(e => e.ErrorMessage));
                throw new ValidationException(errorMessages);
            }
        }
    }
}
