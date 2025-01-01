using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class Employee
    {
        #region properties
        //Employee is identified by an ID, Name, security level, salary, hire date and Gender.
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Gender Gender { get; set; }
        public Security SecurityLevel { get; set; }
        public HireDate Hiredate { get; set; }
        #endregion
        #region Constructors
        public Employee(int iD, string name, decimal salary, Gender gender, Security securityLevel, HireDate hiredate)
        {
            ID = iD;
            Name = name;
            Salary = salary;
            Gender = gender;
            SecurityLevel = securityLevel;
            Hiredate = hiredate;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Employee ID: {ID}\nName: {Name}\nGender: {Gender}\nSecurity Level: {SecurityLevel}\nSalary: {Salary:C}\nHire Date: {Hiredate.ToString()}";
        }
        #endregion
    }
}
