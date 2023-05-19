using Business.Abstract;
using Business.Constants;
using Business.ValidationRules;
using Core.Results;
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
    public class StaffManager : IStaffService
    {
        IStaffDal _staffDal;
        StaffValidator staffValidatior;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public IResult Delete(int id)
        {
            var item = _staffDal.Get(s=>s.Id == id);
            if(item != null)
            {
                _staffDal.Delete(id);

                return new SuccessResult();
            }
            
            return new ErrorResult(Messages.StaffNotFound);
        }

        public IDataResult<List<Staff>> GetAll()
        {
            return new SuccessDataResult<List<Staff>>(_staffDal.GetAll(),Messages.StaffsListed);
        }

        public IDataResult<Staff> GetById(int id)
        {
            return new SuccessDataResult<Staff>(_staffDal.Get(a => a.Id == id));
        }

        public IResult Post(Staff staff)
        {

            _staffDal.Post(staff);
            return new SuccessResult();
        }

        public IResult Put(Staff staff)
        {
            _staffDal.Put(staff);
            return new SuccessResult();
        }
    }
}
