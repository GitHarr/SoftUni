namespace Employee.App.Core.Controllers
{
    using System;
    using System.Linq;
    using App.Core.Contracts;
    using App.Core.DTOs;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Employee.Data;
    using Employee.Models;

    public class EmployeeController : IEmployeeController
    {
        private readonly EmployeeContext context;
        private readonly IMapper mapper;

        public EmployeeController(EmployeeContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public void AddEmployee(EmployeeDto employeeDto)
        {
            var employee = mapper.Map<Employee>(employeeDto);

            this.context.Employees.Add(employee);

            this.context.SaveChanges();
        }

        public void SetAddress(int employeeId, string address)
        {
            var employee = context.Employees.Find(employeeId);

            if (employee == null)
            {
                throw new ArgumentException("Ivalid Id");
            }

            employee.Address = address;

            context.SaveChanges();
        }

        public void SetBirthday(int employeeId, DateTime date)
        {
            var employee = context.Employees.Find(employeeId);

            if (employee == null)
            {
                throw new ArgumentException("Ivalid Id");
            }

            employee.Birthday = date;

            context.SaveChanges();
        }

        public EmployeeDto GetEmployeeInfo(int employeeId)
        {
            var employee = context.Employees
                                  .Find(employeeId);

            var employeeDto = mapper.Map<EmployeeDto>(employee);

            if (employee == null)
            {
                throw new ArgumentException("Ivalid Id");
            }

            return employeeDto;
        }

        public EmployeePersonalInfoDto GetEmployeePersonalInfo(int employeeId)
        {
            var employee = context.Employees
                                  .Find(employeeId);

            var employeeDto = mapper.Map<EmployeePersonalInfoDto>(employee);

            if (employee == null)
            {
                throw new ArgumentException("Ivalid Id");
            }

            return employeeDto;
        }
    }
}
