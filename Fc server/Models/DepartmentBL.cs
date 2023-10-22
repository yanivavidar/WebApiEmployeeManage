using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FactoryProject.Models
{
    public class DepartmentBL
    {
        YanivDataBaseEntities db = new YanivDataBaseEntities();

        public List<Department> getAllDepartments()
        {
            return db.Department.ToList();
        }
        public Department getDepartment(int id)
        {
            return db.Department.Where(x => x.ID == id).First();
        }

        public void AddDepartment(Department department)
        {
            db.Department.Add(department);
            db.SaveChanges();
        }
        public void UpdateDepartment(int id,Department department)
        {
            var result = db.Department.Where(x=> x.ID == id).First();
            result.Manager = department.Manager;
            result.Name = department.Name;
            db.SaveChanges();
        }
        public void RemoveDepartment(int id)
        {
            var result = db.Department.Where(x => x.ID == id).First();
            db.Department.Remove(result);
            db.SaveChanges();
        }
    }
}