using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LicenseManager : ILicenseService
    {
        public ILicenseDal _licenseDal;
        public LicenseManager(ILicenseDal licensedal)
        {
            _licenseDal = licensedal;
        }
        public void Add(License license)
        {
            try
            {
                _licenseDal.Add(license);
                Console.WriteLine("Lisans bilgileri başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lisans bilgileri eklenirken bir hata oluştu.");
            }
        }

        public void Update(License license)
        {
            _licenseDal.Update(license);
        }

        public void Delete(License license)
        {
            _licenseDal.Delete(license);
        }

        public List<License> GetAll()
        {
            return _licenseDal.GetAll();
        }

        public List<License> GetByLicenseId(int licenseId)
        {
            return _licenseDal.GetAll(l => l.LicenseID == licenseId);
        }
    }
}
