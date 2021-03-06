﻿using System;
using System.Collections.Generic;
using DataAccessLayer;
using BLogic.Model;

namespace BLogic
{
    public class BuisnessLogic : IServiceNetwork
    {
        private readonly DatabaseAccess dbAccess;

        public BuisnessLogic()
        {
            dbAccess = new DatabaseAccess();
            
        }

        #region Employee...

        public Employee[] GetEmployees(bool showArchive)
        {
            DataAccessLayer.Model.Employee[] employees = dbAccess.GetEmployees(showArchive);

            List<Employee> result = new List<Employee>();

            foreach (var employee in employees)
            {
                result.Add(new Employee(employee));
            }

            return result.ToArray();
        }

        public int AddEmployee(string firstName, string lastName, string middleName, string description = null)
        {
            return dbAccess.AddEmployee(new DataAccessLayer.Model.Employee(firstName, lastName, middleName, description));
        }

        public void RemoveEmployee(int employeeId)
        {
            dbAccess.RemoveEmployee(employeeId);
        }

        public void ChangeEmployeeFullName(int employeeId, string firstName, string lastName, string middleName, string description = null)
        {
            dbAccess.UpdateEmployee(new DataAccessLayer.Model.Employee
            {
                Id = employeeId,
                LastName = lastName,
                FirstName = firstName,
                MiddleName = middleName,
                Description = description
            });
        }

        #endregion Employee...
        
        #region Contragent...

        public Contragent[] GetContragents(bool showArchive)
        {
            DataAccessLayer.Model.Contragent[] contragents = dbAccess.GetContragents(showArchive);

            List<Contragent> result = new List<Contragent>();

            foreach (var contragent in contragents)
            {
                result.Add(new Contragent(contragent));
            }

            return result.ToArray();
        }

        public void AddContragent(string title, string comment)
        {
            dbAccess.AddContragent(new DataAccessLayer.Model.Contragent(title, comment));
        }

        public void ChangeContragentData(int contragentId, string title, string comment)
        {
            dbAccess.UpdateContragent(new DataAccessLayer.Model.Contragent
            {
                Id = contragentId,
                Title = title,
                Comment = comment
            });
        }

        public void RemoveContragent(int contragentId)
        {
            dbAccess.RemoveContragent(contragentId);
        }

        #endregion Contragent...
        /*
        #region Item...

        public Item[] GetItems(bool showArchive)
        {
            return dbAccess.GetItems(showArchive);
        }

        public void AddItem(string itemName, bool isRevenue, string description)
        {
            dbAccess.AddItem(new Item(itemName, isRevenue, description));
        }

        public void RemoveItem(int itemId)
        {
            dbAccess.RemoveItem(itemId);
        }

        #endregion Item...

        #region Subitem...

        public Subitem[] GetSubitems(bool showArchive)
        {
            return dbAccess.GetSubitems(showArchive);
        }

        public void AddSubitem(string subitemName, int itemId, string description)
        {
            dbAccess.AddSubitem(new Subitem(subitemName, itemId, description));
        }

        public void RemoveSubitem(int subitemId)
        {
            dbAccess.RemoveSubitem(subitemId);
        }

        #endregion Subitem...

        #region Taxrate...

        public Taxrate[] GetTaxrates(bool showArchive)
        {
            return dbAccess.GetTaxrates(showArchive);
        }

        public void AddTaxrate(int taxPercent, string description)
        {
            dbAccess.AddTaxrate(new Taxrate(taxPercent, description));
        }

        public void RemoveTaxrate(int taxrateId)
        {
            dbAccess.RemoveTaxrate(taxrateId);
        }

        #endregion Taxrate...

        #region Operations...
        public Operation[] GetOperations(bool showArchive)
        {
            return dbAccess.GetOperations(showArchive);
        }

        public void AddOperation(DateTime operationDate, int contragentId, int employeeId, int subitemId, int taxrateId, decimal revenue, decimal earnings)
        {
            dbAccess.AddOperation(new Operation
            {
                OperationDate = operationDate,
                ContragentId = contragentId,
                EmployeeId = employeeId,
                SubitemId = subitemId,
                TaxrateId = taxrateId,
                Revenue = revenue,
                Earnings = earnings
            });
        }

        public void RemoveOperation(int operationId)
        {
            dbAccess.RemoveOperation(operationId);
        }

        #endregion Operations...*/
    }
}
