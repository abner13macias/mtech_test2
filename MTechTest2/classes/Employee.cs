using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTechTest2.classes
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string RFC { get; set; }
        public DateTime BornDate { get; set; }
        public EmployeeStatus Status { get; set; }
    }

    public enum EmployeeStatus
    {
        NotSet,
        Active,
        Inactive,
    }

}
