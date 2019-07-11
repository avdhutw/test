using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demochatboot.Models;
using Demochatboot.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demochatboot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        IChartbootsRepository chartbootsRepository;
        public HomeController()
        {
            chartbootsRepository = new ChartbootsRepository();
        }


        [HttpPost("Insertchartboots")]
        public object InsertCompany(Company company)
        {

            chartbootsRepository.Insertchartboots(company);
            return "insert success";
        }

        [HttpGet("Selectchartboots")]
        public List<Company> Selectchartboots()
        {
            List<Company> listCompany = chartbootsRepository.Selectchartboots();
            return listCompany;
        }

        [HttpGet("GetchartbootsById")]
        public Company GetchartbootsById(int id)
        {
            return chartbootsRepository.GetchartbootsById(id);
        }

        [HttpPut("Updatechartboots")]
        public object Updatechartboots(Company company)
        {
            chartbootsRepository.Updatechartboots(company);
            return "updete success";
        }

        [HttpDelete("Deletechartboots")]
        public object Deletechartboots(Company company)
        {
            chartbootsRepository.Deletechartboots(company);
            return "delete success";
        }
    }
}