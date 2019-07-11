using Demochatboot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demochatboot.Repository
{
     public interface IChartbootsRepository
    {

        void Insertchartboots(Company chartboots);
        List<Company> Selectchartboots();
        Company GetchartbootsById(int id);
        void Updatechartboots(Company chartboots);
        void Deletechartboots(Company chartboots);
    }
}
