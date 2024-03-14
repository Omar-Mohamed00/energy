using energy.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace energy.Controllers
{
    public class GraphController : Controller
    {
        public readonly AppDbContext _dbContext;

        public GraphController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult showData()
        {
            return View();
        }
        [HttpPost]
        public List<object> GetSalesData()
        {
            List<object> data = new List<object>();
            List<DateTime> labels = _dbContext.device1.Select(p => p.Time).ToList();

            data.Add(labels);
            List<int> salesCurrent = _dbContext.device1.Select(p => p.current).ToList();
            List<int> salesKWHour = _dbContext.device1.Select(p => p.KWHour).ToList();
            List<int> salesVolt = _dbContext.device1.Select(p => p.volt).ToList();
            data.Add(salesCurrent);
            data.Add(salesKWHour);
            data.Add(salesVolt);

            return data;
        }
        public IActionResult showData2()
        {
            return View();
        }
        [HttpPost]
        public List<object> Device2()
        {
            List<object> data = new List<object>();
            List<DateTime> labels = _dbContext.device2.Select(p => p.Time).ToList();

            data.Add(labels);
            List<int> salesCurrent = _dbContext.device2.Select(p => p.current).ToList();
            List<int> salesKWHour = _dbContext.device2.Select(p => p.KWHour).ToList();
            List<int> salesVolt = _dbContext.device2.Select(p => p.volt).ToList();
            data.Add(salesCurrent);
            data.Add(salesKWHour);
            data.Add(salesVolt);

            return data;
        }
    }
}
