using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryProject.Models
{
    public class EmployeeWithShiftBL
    {
        YanivDataBaseEntities db = new YanivDataBaseEntities();

        public List<EmployeeWithShift> getAllEmployeesWithShift()
        {
            List<EmployeeWithShift> emps = new List<EmployeeWithShift>();

            foreach (var emp in db.Employee)
            {
                EmployeeWithShift newEmpWithShift = new EmployeeWithShift();
                newEmpWithShift.ID = emp.ID;
                newEmpWithShift.FirstName = emp.FirstName;
                newEmpWithShift.LastName = emp.LastName;
                newEmpWithShift.StartWorkYear = emp.StartWorkYear;
                newEmpWithShift.DepartmentID = emp.DepartmentID;

                newEmpWithShift.ShiftsList = new List<EmpShiftList>();
                

                var shifts = db.EmployeeShift.Where(x => x.EmployeeID == emp.ID);
                foreach (var shift in shifts)
                {
                    var InnerShifts = db.Shift.Where(x => x.ID == shift.ShiftID);
                    //foreach (var InnShift in InnerShifts)
                    //{

                    //    newEmpWithShift.ShiftsList.Add(InnShift.ID.ToString());
                    //    newEmpWithShift.ShiftsList.Add(InnShift.Date.ToString());
                    //    newEmpWithShift.ShiftsList.Add(InnShift.StartTime.ToString());
                    //    newEmpWithShift.ShiftsList.Add(InnShift.EndTime.ToString());
                    //}
                    foreach (var InnShift in InnerShifts)
                    {
                        EmpShiftList EmpShiftList = new EmpShiftList
                        {
                            ID = InnShift.ID,
                            Date = InnShift.Date,
                            StartTime = InnShift.StartTime,
                            EndTime = InnShift.EndTime
                        };

                        newEmpWithShift.ShiftsList.Add(EmpShiftList);
                    }


                }
                emps.Add(newEmpWithShift);
            }
            return emps;

        }

        



    }
}