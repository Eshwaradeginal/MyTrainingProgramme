using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DataComponent
{
    public interface IDataClasses
    {
        void AddNewEmployee(MVCEmployee emp);
        void UpdateEmployee(MVCEmployee emp);
        void DeleteEmployee(int id);
        List<MVCEmployee> GetAllEmployees();
        List<MVCDepartment> GetAllDepts();
    }
    public class EmployeeDataComponent : IDataClasses
    {
        private readonly EmployeeEntities entities = new EmployeeEntities();
        public void AddNewEmployee(MVCEmployee emp)
        {
            entities.MVCEmployees.Add(emp);
            entities.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var found = entities.MVCEmployees.FirstOrDefault((p) => p.Empid == id);
            if (found != null)
            {
                entities.MVCEmployees.Remove(found);
            }
            else
            {
                throw new Exception("Employee Id not Found to delete");
            }
        }

        public List<MVCDepartment> GetAllDepts()
        {
            return entities.MVCDepartments.ToList();
        }

        public List<MVCEmployee> GetAllEmployees()
        {
            return entities.MVCEmployees.ToList();
        }

        public void UpdateEmployee(MVCEmployee emp)
        {
            var found = entities.MVCEmployees.FirstOrDefault((p) => p.Empid == emp.Empid);
            if (found!= null)
            {
                found.Empid = emp.Empid;
                found.EmpName = emp.EmpName;
                found.EmpSalary = emp.EmpSalary;
                found.DeptId = emp.DeptId;
                entities.SaveChanges();
            }
            else
            {
                throw new Exception("Employee not found to update");
            }
        }
    }
}

