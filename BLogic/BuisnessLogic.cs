using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Model;

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
            return dbAccess.GetEmployees(showArchive);
        }

        public void AddEmployee(string firstName, string lastName, string middleName, string description = null)
        {
            dbAccess.AddEmployee(new Employee(firstName, lastName, middleName, description));
        }

        public void RemoveEmployee(int employeeId)
        {
            dbAccess.RemoveEmployee(employeeId);
        }

        public void ChangeEmployeeFullName(int employeeId, string firstName, string lastName, string middleName, string description = null)
        {
            dbAccess.UpdateEmployee(new Employee
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
            return dbAccess.GetContragents(showArchive);
        }

        public void AddContragent(string title, string comment)
        {
            dbAccess.AddContragent(new Contragent(title, comment));
        }

        public void RemoveContragent(int contragentId)
        {
            dbAccess.RemoveContragent(contragentId);
        }

        #endregion Contragent...

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

        #endregion Operations...
    }
}
