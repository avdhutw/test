using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demochatboot.Models;

namespace Demochatboot.Repository
{
    public class ChartbootsRepository : IChartbootsRepository
    {
        ChartbootsContext chartcontext;

        public ChartbootsRepository()
        {
            chartcontext = new ChartbootsContext();
        }
        public void Deletechartboots(Company chartboots)
        {
            chartcontext.Company.Remove(chartboots);
            int result = chartcontext.SaveChanges();
        }

        public Company GetchartbootsById(int id)
        {
            return chartcontext.Company.Where<Company>(i => i.Empid == id).FirstOrDefault<Company>();
        }

        public void Insertchartboots(Company chartboots)
        {
            chartcontext.Company.Add(chartboots);
            int result = chartcontext.SaveChanges();
            chartcontext.Dispose();
        }

        public List<Company> Selectchartboots()
        {
            return chartcontext.Company.ToList<Company>();
        }

        public void Updatechartboots(Company chartboots)
        {
            chartcontext.Company.Update(chartboots);
            int result = chartcontext.SaveChanges();
        }

   

         
        
    }
}
