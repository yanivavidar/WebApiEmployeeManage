using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryProject.Models
{
    public class EmployeeWithShift
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StartWorkYear { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public List<EmpShiftList> ShiftsList { get; set; }

    }
    public class EmpShiftList
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> StartTime { get; set; }
        public Nullable<int> EndTime { get; set; }
    }
}