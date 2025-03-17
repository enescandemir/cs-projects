using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfVersionDal : EfEntityRepositoryBase<Entities.Concrete.Version,LicenseTrackContext>, IVersionDal
    {
    }
}
