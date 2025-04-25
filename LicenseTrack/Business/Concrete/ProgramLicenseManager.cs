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
    public class ProgramLicenseManager : IProgramLicenseService
    {
        IProgramLicenseDal _programLicenseDal;
        public ProgramLicenseManager(IProgramLicenseDal programLicenseDal)
        {
            _programLicenseDal = programLicenseDal;
        }
        public void Add(ProgramLicense programLicense)
        {
            try
            {
                _programLicenseDal.Add(programLicense);
                Console.WriteLine("Program lisansı başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                throw new Exception("Program lisansı eklenirken hata meydana geldi.", ex);

            }

        }
        public void Update(ProgramLicense programLicense)
        {
            _programLicenseDal.Update(programLicense);
        }

        public void Delete(ProgramLicense programLicense)
        {
            _programLicenseDal.Delete(programLicense);
        }

        public List<ProgramLicense> GetAll()
        {
            return _programLicenseDal.GetAll();
        }

        public List<ProgramLicense> GetByProgramLicenseId(int programLicenseId)
        {
            return _programLicenseDal.GetAll(pL => pL.ProgramLicenseID == programLicenseId);
        }
        public List<ProgramLicense> GetByLicenseId(int licenseId)
        {
            return _programLicenseDal.GetAll(pl => pl.LicenseID == licenseId);
        }
        public List<ProgramLicense> GetByProgramId(int programId)
        {
            return _programLicenseDal.GetAll(pl => pl.ProgramID == programId);
        }

        public List<ProgramLicenseDto> GetAllWithNames()
        {
            using (var context = new LicenseTrackContext())
            {
                var result = from programLicense in context.ProgramLicense
                             join program in context.Program
                             on programLicense.ProgramID equals program.ProgramID
                             join license in context.License
                             on programLicense.LicenseID equals license.LicenseID
                             join customer in context.Customer
                             on license.CustomerID equals customer.CustomerID
                             select new ProgramLicenseDto
                             {
                                 ProgramLicenseID = programLicense.ProgramLicenseID,
                                 ProgramName = program.Name,
                                 LicenseID = license.LicenseID,
                                 CustomerName = customer.Name,
                                 LicenseType = license.Type,
                                 LicenseStartDate = license.StartDate,
                                 LicenseEndDate = license.EndDate,
                                 LicenseDescription = license.Description
                             };

                return result.ToList();
            }
        }




    }
}
