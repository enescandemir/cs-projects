using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProgramService
    {
        List<Program> GetAll();
        List<Program> GetByProgramId(int programId);
        void Add(Program program);
        void Update(Program program);
        void Delete(Program program);
    }
}
