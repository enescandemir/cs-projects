using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IUpdateTableService
    {
        List<UpdateTable> GetAll();
        List<UpdateTable> GetByUpdateId(int updateTableId);
        void Add(UpdateTable updateTable);
        void Update(UpdateTable updateTable);
        void Delete(UpdateTable updateTable);
    }
}
