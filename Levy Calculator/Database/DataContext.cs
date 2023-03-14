using Microsoft.EntityFrameworkCore;

namespace Levy_Calculator.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<YearCoefficient> YearCoefficients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var list = new List<YearCoefficient>();
            for (int i = 1965; i <= 1999; i++)
            {
                list.Add(new YearCoefficient(year: i, coefficient: 5));
            }
            list.AddRange(new List<YearCoefficient>(){
                new YearCoefficient(
                    year: 2000,
                    coefficient: 2.4),
                    new YearCoefficient(
                    year: 2001,
                    coefficient: 2.5),
                      new YearCoefficient(
                    year: 2002,
                    coefficient: 2.8)});
            for (int i = 2003; i <= 2017; i++)
            {
                list.Add(new YearCoefficient(year: i, coefficient: 3));
            }
            for (int i = 2018; i <= 2022; i++)
            {
                list.Add(new YearCoefficient(year: i, coefficient: 1.5));
            }
            list.Add(new YearCoefficient(
                    year: 2023,
                    coefficient: 1.3));


            modelBuilder.Entity<YearCoefficient>().HasData(list);

        }

    }
}