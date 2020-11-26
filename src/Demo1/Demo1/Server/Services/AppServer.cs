using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo1.Shared.Model;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace Demo1.Server.Services
{
    /// <summary>
    /// Scoped: 
    /// Ny for hver bruker, men gjenbrukes av denne samme brukeren. 
    /// </summary>
    internal class AppServer 
    {
        private readonly DbWorker _db;
        private readonly ILogger _log;

        internal AppServer()
        { 
        }

        internal AppServer(DbWorker db, ILogger<AppServer> logger)
        {
            logger.LogInformation("AppServer starting: Scoped");
            _log = logger;
            _db = db;
        }

        /// <summary>
        ///  Ikke i bruk, kun for demo
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        internal AppServer UseConfig(IConfigurationSection config)
        {
            Console.WriteLine($"The Key = {config["TheKey"]}");                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
            return this;
        }

        internal List<Department> GetDepartments()
        {
            var depts = _db.Department.Where(c => true);
            return depts.ToList();
        }

        internal List<Department> GetDepartmentsByName(string filter)
        {
            var depts = _db.Department.Where(c => c.DepartmentName.Equals(filter));
            return depts.ToList();
        }

        internal async Task<bool> SaveChanges(Department department)
        {
            try
            {
                var depts = _db.Department.Update(department);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException dbuexc)
            {
                _log.LogError(dbuexc, "DBerror: {dbuexc.Message} on save department {department.");
            }
            catch (Exception exc)
            {
                _log.LogError(exc, "DB general error: {exc.Message} on save department {department.");
            }
            return false;
        }
        internal async Task<bool> SaveChanges(Employee employee)
        {
            var depts = _db.Employee.Update(employee);
            await _db.SaveChangesAsync();
            return true;
        }
        internal async Task<bool> SaveChanges(Student student)
        {
            var depts = _db.Student.Update(student);
            await _db.SaveChangesAsync();
            return true;
        }


        internal List<Employee> GetEmployee(int EmployeeID)
        {
            var employee = _db.Employee.Where(c => c.EmployeeID.Equals(EmployeeID)).Include(d => d.Department);
            return employee.ToList();
        }

        internal List<Employee> GetEmployeeList()
        {
            var employee = _db.Employee.Where(c => true).Include(d => d.Department);
            return employee.ToList();
        }
    }




}
