
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	//[EnableCors()]
	public class EmployeeController : ControllerBase
	{
		static List<Employee> data = new List<Employee>()
		{
			new Employee(){empId =1, empName ="Employee 1", address ="address 1" },
			new Employee{empId =2, empName ="Employee 2", address ="address 2" },
			new Employee{empId =3, empName ="Employee 3", address ="address 3" }
		};
		[HttpGet]
		public IActionResult Get()
		{
			return Ok(data);
		}

		[HttpPost]
		public IActionResult Post(Employee e)
		{
			e.empId = data.Count > 0 ? data.Max(e => e.empId) + 1 : 1;


			data.Add(e);

			return Ok(e);
		}

	}
}
