using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class VersionManager : IVersionService
    {
        IVersionDal _versionDal;
        public VersionManager(IVersionDal versionDal)
        {
            _versionDal = versionDal;
        }

        public void Add(Entities.Concrete.Version version)
        {
            try
            {
                _versionDal.Add(version);
                Console.WriteLine("Versiyon bilgileri başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Versiyon bilgileri eklenirken bir hata oluştu.");
            }
        }
        public void Update(Entities.Concrete.Version version)
        {
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


    }
}
