using Microsoft.EntityFrameworkCore;
using HippoAPIAssignment.Interface;
using HippoAPIAssignment.Models;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebAPIAssignment.Repository
{
    public class EmployeeRepository: IEmployees
    {
       
        private readonly ServerDBContext _dbContext;
        public EmployeeRepository(ServerDBContext context)
        {
            _dbContext = context;
        }

        public List<Employee> GetEmployeeDetails()
        {
            try
            {
                return _dbContext.Employee.ToList();
            }
            catch
            {
                throw;
            }   
        }
        public Employee GetEmployeeDetails(int id)
        {
            try
            {
                Employee? employee = _dbContext.Employee.Find(id);
                if (employee != null)
                {
                    return employee;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
        public void AddEmployee(Employee employee)
        {
            try
            {
                _dbContext.Employee.Add(employee);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            try
            {
                _dbContext.Entry(employee).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Employee DeleteEmployee(int id)
        {
            try
            {
                Employee? employee = _dbContext.Employee.Find(id);

                if (employee != null)
                {
                    _dbContext.Employee.Remove(employee);
                    _dbContext.SaveChanges();
                    return employee;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public bool CheckEmployee(int id)
        {
            return _dbContext.Employee.Any(e => e.EmployeeID == id);
        }
    }
}
