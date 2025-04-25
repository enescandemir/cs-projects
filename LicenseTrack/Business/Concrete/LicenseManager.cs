using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.Concrete.DTOs;
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
        public List<CustomerLicenseDto> GetAllWithNames()
        {
            try
            {
                using (var context = new LicenseTrackContext())
                {
                    var licensesWithNames = from license in _licenseDal.GetAll()
                                            join customer in context.Customer
                                            on license.CustomerID equals customer.CustomerID
                                            select new CustomerLicenseDto
                                            {
                                                LicenseID = license.LicenseID,
                                                CustomerName = customer.Name,
                                                Type = license.Type,
                                                StartDate = license.StartDate,
                                                EndDate = license.EndDate,
                                                Description = license.Description
                                            };

                    return licensesWithNames.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lisans ve müşteri bilgileri birleştirilirken bir hata oluştu: " + ex.Message);
                return new List<CustomerLicenseDto>();
            }
        }



    }
}
