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
    public class UpdateTableManager : IUpdateTableService
    {
        IUpdateTableDal _updateTableDal;
        public UpdateTableManager(IUpdateTableDal updateTableDal)
        {
            _updateTableDal = updateTableDal;
        }
        public void Add(UpdateTable updateTable)
        {
            try
            {
                _updateTableDal.Add(updateTable);
                Console.WriteLine("Güncelleme bilgisi başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                throw new Exception("Güncelleme tablosu eklenirken hata meydana geldi.", ex);

            }

        }
        public void Update(UpdateTable updateTable)
        {
            _updateTableDal.Update(updateTable);
        }

        public void Delete(UpdateTable updateTable)
        {
            _updateTableDal.Delete(updateTable);
        }

        public List<UpdateTable> GetAll()
        {
            return _updateTableDal.GetAll();
        }

        public List<UpdateTable> GetByUpdateId(int updateId)
        {
            return _updateTableDal.GetAll(u => u.UpdateID == updateId);
        }
    }
}


