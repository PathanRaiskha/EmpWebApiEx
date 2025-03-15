using EmpWebApiEx.model.entity;
using EmpWebApiEx.viewmodel;

namespace EmpWebApiEx.srevices
{
    public interface IempolyServices
    {
        public ApiRisponse GetAllEmployDetail();
        public ApiRisponse AddEmployDetail(employ employ);
        public ApiRisponse UpdateEmployDetail(int Id, employ employ);
        public ApiRisponse RemoveEmployDetail(int id);
    }
}
