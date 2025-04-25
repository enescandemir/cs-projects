using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.Concrete.DTOs.Entities.Concrete.DTOs;
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
        public List<UpdateTableDto> GetAllWithNames()
        {
            try
            {
                using (var context = new LicenseTrackContext()) 
                {
                    var updatesWithNames = from update in context.UpdateTable
                                           join customer in context.Customer
                                           on update.CustomerID equals customer.CustomerID
                                           join version in context.Version
                                           on update.VersionID equals version.VersionID
                                           select new UpdateTableDto
                                           {
                                               UpdateID = update.UpdateID,
                                               CustomerName = customer.Name, 
                                               VersionName = version.Name,  
                                               UpdateDate = update.UpdateDate,
                                               Description = update.Description
                                           };

                    return updatesWithNames.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Güncelleme ve ad bilgileri birleştirilirken bir hata oluştu: " + ex.Message);
                return new List<UpdateTableDto>();
            }
        }

    }
}


