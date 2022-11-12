using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Assignment
{
    internal class Manager:Employee
    {
        private double PA, FA, OA, PF, TDS, netSalary;
        public override double calculateSalary(double Salary)
        {
            double baseSalary = base.calculateSalary(Salary);
            PA = 0.08 * Salary;
            FA = 0.13 * Salary;
            OA = 0.03 * Salary;
            double grossSalary = baseSalary + PA + FA + OA;
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
