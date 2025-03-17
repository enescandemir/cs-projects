using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProgramLicenseService
    {
        List<ProgramLicense> GetAll();
        List<ProgramLicense> GetByProgramLicenseId(int pLicenseId);
        void Add(ProgramLicense pLicense);
        void Update(ProgramLicense pLicense);
        void Delete(ProgramLicense pLicense);
    }
}
