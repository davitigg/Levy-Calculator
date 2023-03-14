using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Levy_Calculator
{
    [Table("YearCoefficients")]
    public class YearCoefficient
    {
        [Key]
        public int Year { get; set; }
        public double Coefficient { get; set; }

        public YearCoefficient(int year, double coefficient)
        {
            Year = year;
            Coefficient = coefficient;
        }
    }
}
