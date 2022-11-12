using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Assignment
{
    internal class Employee
    {
        private double HRA, TA, PF, DA, TDS, NetSalary, GrossSalary;

        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }

        public virtual double calculateSalary(double Salary)
        {
            try
            {
                if (Salary < 5000)
                {
                    HRA = Salary * 10 / 100; TA = Salary * 5 / 100; DA = Salary * 15 / 100;
                }
                else if (Salary > 5000 && Salary < 10000)
                {
                    HRA = Salary * 15 / 100; TA = Salary * 10 / 100; DA = Salary * 20 / 100;


                }
                else if (Salary > 10000 && Salary < 15000)
                {
                    HRA = Salary * 20 / 100; TA = Salary * 15 / 100; DA = Salary * 25 / 100;


                }
                else if (Salary > 15000 && Salary < 20000)
                {
                    HRA = Salary * 25 / 100; TA = Salary * 20 / 100; DA = Salary * 30 / 100;


                }
                else
                {
                    HRA = Salary * 30 / 100; TA = Salary * 25 / 100; DA = Salary * 35 / 100;


                }
                GrossSalary = Salary + HRA + TA + DA;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Salary cannot be zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Give a proper salary ");
            }
            PF = GrossSalary * 10 / 100;
            TDS = GrossSalary * 18 / 100;
            NetSalary = GrossSalary - (PF + TDS);
            return GrossSalary;
        }

    }
}
