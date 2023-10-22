using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryProject.Models
{
    public class EmployeeBLs
    {
        YanivDataBaseEntities db = new YanivDataBaseEntities();

        public List<Employee> getAllEmployees()
        {
            return db.Employee.ToList();
        }
        public Employee getEmployee(int id)
        {
            try
            {
                var result = db.Employee.FirstOrDefault(x => x.ID == id);
                return result;
            }
            catch (Exception)
            {

                throw new InvalidOperationException("employee not found");
            }
        }

        public string AddEmployee(Employee department)
        {
            db.Employee.Add(department);
            db.SaveChanges();
            return "employee added";
        }
        public string UpdateEmployee(int id, Employee employee)
        {
            var result = db.Employee.Where(x => x.ID == id).First();

            result.FirstName = employee.FirstName;
            result.LastName = employee.LastName;
            result.StartWorkYear = employee.StartWorkYear;
            result.DepartmentID = employee.DepartmentID;
            db.SaveChanges();
            return "employee updated";
        }
        public string RemoveEmployee(int id)
        {
            var result = db.Employee.Where(x => x.ID == id).First();
            db.EmployeeShift.RemoveRange(result.EmployeeShift);
            db.Employee.Remove(result);
            db.SaveChanges();
            return "employee removed";
        }
    }
}