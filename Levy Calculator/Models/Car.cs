namespace Levy_Calculator.Models
{
    public class Car
    {
        //private Dictionary<int, double> Coefficients = new Dictionary<int, double>()
        //{
        //    { 2000, 2.4 }, { 2001, 2.5 }, { 2002, 2.8 }, { 2003, 3 },{ 2004, 3 },{ 2005, 3 },{ 2006, 3 },{ 2007, 3 },{ 2008, 3 },
        //    { 2009, 3 }, { 2010, 3 }, { 2011, 3 }, { 2012, 3 }, { 2013, 3 }, { 2014, 3 }, { 2015, 3 }, { 2016, 3 },
        //    { 2017, 1.5 }, { 2018, 1.5 }, { 2019, 1.5 }, { 2020, 1.5 }, { 2021, 1.5 }, { 2022, 1.5 }, { 2023, 1.3 }
        //};


        public bool Electric { get; set; } = false;
        public bool Hybrid { get; set; } = false;
        public bool RightWheelOrMoved { get; set; } = false;
        public int Year { get; set; }
        private YearCoefficient? YearCoefficient { get; set; }
        public double Engine { get; set; }

        public Car(bool hybrid, bool electric, bool rightWheelOrMoved, int year, double engine)
        {
            if (Convert.ToInt32(electric) + Convert.ToInt32(hybrid) < 2)
            {
                Hybrid = hybrid;
                Electric = electric;
            }
            else throw new ArgumentException("car can't be both hybrid and electric");
            RightWheelOrMoved = rightWheelOrMoved;
            if (year >= 1965 && year <= 2023)
            {
                Year = year;
            }
            else throw new ArgumentException("year must be between 1965 and 2023");
            if (electric)
            {
                if (engine == 0)
                {
                    Engine = engine;
                }
                else throw new ArgumentException("electric car's engine can't be more than 0");
            }
            else if (engine >= 0.1 && engine <= 6.5)
            {
                Engine = engine;
            }
            else throw new ArgumentException("engine must be between 0.1 and 6.5");
        }

    }
}
