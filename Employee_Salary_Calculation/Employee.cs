using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Salary_Calculation
{
    internal class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public float BasicSalary { get; set; }
        public float HRA { get; set; }
        public float TA { get; set; }
        public float DA { get; set; }
        public float PF { get; set; }
        public float TDS { get; set; }
        public float GrossSalary { get; set; }
        public float NetSalary { get; set; }
        public void calculateSalary()
        {
            if (BasicSalary <= 10000)
            {
                HRA = 10 * BasicSalary / 100;
                TA = 8 * BasicSalary / 100;
                DA = 5 * BasicSalary / 100;
            }
            else if (BasicSalary <= 15000)
            {
                HRA = 12 * BasicSalary / 100;
                TA = 10 * BasicSalary / 100;
                DA = 8 * BasicSalary / 100;
            }
            else
            {
                HRA = 15 * BasicSalary / 100;
                TA = 12 * BasicSalary / 100;
                DA = 10 * BasicSalary / 100;
            }
            GrossSalary = BasicSalary + HRA + TA + DA;
            PF = GrossSalary * 5 / 100;
            TDS = GrossSalary * 3 / 100;
            NetSalary = GrossSalary - (PF + TDS);
        }

        public void reset()
        {
            EmpNo = 0;
            Name = "";
            BasicSalary = 0;
            HRA = 0;
            TA = 0;
            DA = 0;
            PF = 0;
            TDS = 0;
            GrossSalary = 0;
            NetSalary = 0;
        }
    }
}
