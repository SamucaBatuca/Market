using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Objects
{
    class Employee
    {
        [Key]
        public int Id_Employee { get; private set; }
        public string CPF_Employee { get; private set; }
        public string Name_Employee { get; private set; }
        public string Role { get; private set; }
        public decimal Salary { get; private set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Regis_Employee { get; private set; }

        protected Employee() { }

        public Employee(string CPF_Employee, string Name_Employee, string Role, decimal Salary)
        {
            this.CPF_Employee = CPF_Employee;
            this.Name_Employee = Name_Employee;
            this.Role = Role;
            this.Salary = Salary;
        }
    }
}