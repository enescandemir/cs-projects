using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IVersionService
    {
        List<Entities.Concrete.Version> GetAll();
        List<Entities.Concrete.Version> GetByVersionId(int versionId);
        void Add(Entities.Concrete.Version version);
        void Update(Entities.Concrete.Version version);
        void Delete(Entities.Concrete.Version version);

    }
}
