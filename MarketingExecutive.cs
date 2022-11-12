using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Assignment
{
    internal class MarketingExecutive:Employee
    {
        private double km, TA, TelA, PF, TDS, netSalary;
        public MarketingExecutive(double _km) { km = _km; }
        public override double calculateSalary(double Salary)
        {
            double baseSalary = base.calculateSalary(Salary);
            TA = km * 5;
            TelA = 1000;
            double grossSalary = baseSalary + TA + TelA;
            PF = grossSalary * 10 / 100;
            TDS = grossSalary * 18 / 100;
            netSalary = grossSalary - (PF + TDS);
            return grossSalary;
        }
        public override string ToString()
        {
            double grossSalary = calculateSalary(Salary);
            return "\nEmployee No.    : " + EmpNo + "\nEmployee Name   : " + EmpName + "\nEmployee Salary : " + Salary +
                "\nGross Salary    : " + grossSalary + "\nPF              : " + PF + "\nTDS             : " + TDS +
                "\nNet Salary      : " + netSalary;
        }

    }
}
