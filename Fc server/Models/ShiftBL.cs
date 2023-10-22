using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryProject.Models
{
    public class ShiftBL
    {
        YanivDataBaseEntities db = new YanivDataBaseEntities();

        public List<Shift> getAllShifts()
        {
            return db.Shift.ToList();
        }
        public Shift getShift(int id)
        {
            return db.Shift.Where(x => x.ID == id).First();
        }

        public void AddShift(Shift value)
        {
            db.Shift.Add(value);
            db.SaveChanges();

        }

        //public string AddEmployee(Employee department)
        //{
        //    db.Employee.Add(department);
        //    db.SaveChanges();
        //    return "Employee added";
        //}
        //public string UpdateEmployee(int id, Employee employee)
        //{
        //    var result = db.Employee.Where(x => x.ID == id).First();

        //    result.FirstName = employee.FirstName;
        //    result.LastName = employee.LastName;
        //    result.StartWorkYear = employee.StartWorkYear;
        //    result.DepartmentID = employee.DepartmentID;
        //    db.SaveChanges();
        //    return "Employee updated";
        //}
        //public string RemoveEmployee(int id)
        //{
        //    var result = db.Employee.Where(x => x.ID == id).First();
        //    db.Employee.Remove(result);
        //    db.SaveChanges();
        //    return "Employee removed";
        //}
    }
}