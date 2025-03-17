using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
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
    }
}
