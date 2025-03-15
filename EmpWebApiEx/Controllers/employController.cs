using EmpWebApiEx.model.entity;
using EmpWebApiEx.srevices;
using EmpWebApiEx.viewmodel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmpWebApiEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class employController : ControllerBase
    {
        private readonly IempolyServices _IempolyServices;
        public employController(IempolyServices ICompanyDetailServices)
        {
            //int a;
            _IempolyServices = ICompanyDetailServices;
        }

        // GET: api/<employController>
        [HttpGet]
        public ApiRisponse get()
        {
            return _IempolyServices.GetAllEmployDetail();
        }

       

        // POST api/<employController>
        [HttpPost]
        public ApiRisponse Post([FromBody] employ employ)
        {
            return _IempolyServices.AddEmployDetail(employ);
        }

        // PUT api/<employController>/5
        [HttpPut("{id}")]
        public ApiRisponse Put([FromRoute] int id, [FromBody] employ employ)
        {
            return _IempolyServices.UpdateEmployDetail(id,employ);
        }

        // DELETE api/<employController>/5
        [HttpDelete("{id}")]
        public ApiRisponse Delete([FromRoute] int id)
        {
            return _IempolyServices.RemoveEmployDetail(id);
        }
    }
}
