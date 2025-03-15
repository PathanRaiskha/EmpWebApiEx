using EmpWebApiEx.data;
using EmpWebApiEx.model.entity;
using EmpWebApiEx.viewmodel;

namespace EmpWebApiEx.srevices
{
    public class employServices: IempolyServices
    {
        private readonly AppDbContext _AppDbContext;

        public employServices(AppDbContext AppDbContext)
        {
            _AppDbContext = AppDbContext;
        }

        public ApiRisponse GetAllEmployDetail()
        {
          var result=  _AppDbContext.employ.ToList();
            return new ApiRisponse {success= true, massege="Recived succesfully", result= result };
        }
        public ApiRisponse AddEmployDetail(employ employ)
        {
            _AppDbContext.employ.Add(employ);
            _AppDbContext.SaveChanges();
            return new ApiRisponse { success = true, massege = " employ Added succesfully", result = null };

        }
        public ApiRisponse UpdateEmployDetail(int Id, employ employ)
        {
            _AppDbContext.employ.Update(employ);
            _AppDbContext.SaveChanges();
            return new ApiRisponse { success=true, massege="employ updatetd succefully",result=null };

        }
        public ApiRisponse RemoveEmployDetail(int id)
        {
            var removingEmploy= _AppDbContext.employ.FirstOrDefault(a=>a.empId==id);    
            _AppDbContext.employ.Remove(removingEmploy);
            _AppDbContext.SaveChanges();
            return new ApiRisponse { success = true, massege = "deleted succefully", result = null };

        }


    }
}
