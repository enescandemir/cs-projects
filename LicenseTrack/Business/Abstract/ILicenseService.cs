using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILicenseService
    {
        List<License> GetAll();
        List<License> GetByLicenseId(int licenseId);
        void Add(License license);
        void Update(License license);
        void Delete(License license);
    }
}
