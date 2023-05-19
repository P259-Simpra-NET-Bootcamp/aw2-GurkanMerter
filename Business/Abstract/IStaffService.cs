using Core.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStaffService
    {
        IDataResult<List<Staff>> GetAll();
        IDataResult<Staff> GetById(int id);
        IResult Put(Staff staff);
        IResult Post(Staff staff);
        IResult Delete(int id);


    }
}
