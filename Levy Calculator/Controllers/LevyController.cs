using Levy_Calculator.Database;
using Levy_Calculator.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Levy_Calculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LevyController : ControllerBase
    {
        private readonly DataContext _context;

        public LevyController(DataContext context)
        {
            _context = context;
        }

        // POST api/<LevyController>
        [HttpPost]
        public ActionResult Post(Car car)
        {
            double customsTax;
            double excise;
            double sum;
            if (car.Electric)
            {
                customsTax = 0;
                excise = 0;
                sum = customsTax + excise;

                return Ok(new Dictionary<string, double> { { "customsTax", customsTax }, { "excise", excise }, { "sum", sum } });
            }
            else
            {
                customsTax = 50;
                var yearCoefficient = _context.YearCoefficients.Where(y => y.Year == car.Year).FirstOrDefault();
                if (yearCoefficient == null)
                {
                    throw new ArgumentNullException("year is in valid range");
                }
                excise = car.Engine * 100 * yearCoefficient.Coefficient;
                if (car.Hybrid && car.Year >= 2018)
                {
                    excise /= 2;
                }
                if (car.RightWheelOrMoved)
                {
                    excise *= 3;
                }
                sum = customsTax + excise;

                return Ok(new Dictionary<string, double> { { "customsTax", customsTax }, { "excise", excise }, { "sum", sum } });
            }
        }
    }
}
