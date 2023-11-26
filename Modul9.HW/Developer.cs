using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9.HW
{
    
        public class Developer : Employee
        {
            private int linesOfCodePerDay;

            public Developer(string name, int age, double salary, int linesOfCodePerDay)
                : base(name, age, salary)
            {
                this.linesOfCodePerDay = linesOfCodePerDay;
            }

            public override void GetInfo()
            {
                base.GetInfo();
                Console.WriteLine($"Кол-во строк кода в день: {linesOfCodePerDay}");
            }

            public override double CalculateAnnualSalary()
            {
                return base.CalculateAnnualSalary() + (linesOfCodePerDay * 1 * 250);
            }
        }

    
}
