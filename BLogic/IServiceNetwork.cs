using System;
using System.Collections.Generic;
using System.ServiceModel;
using BLogic.Model;

namespace BLogic
{
    [ServiceContract]
    public interface IServiceNetwork
    {
        [OperationContract]
        Employee[] GetEmployees(bool showArchive);

        [OperationContract]
        int AddEmployee(string firstName, string lastName, string middleName, string description = null);

        [OperationContract]
        void RemoveEmployee(int employeeId);

        [OperationContract]
        void ChangeEmployeeFullName(int employeeId, string firstName, string lastName, string middleName,
            string description = null);

        
        [OperationContract]
        Contragent[] GetContragents(bool showArchive);

        [OperationContract]
        void AddContragent(string title, string comment);

        [OperationContract]
        void ChangeContragentData(int contragentId, string title, string comment);

        [OperationContract]
        void RemoveContragent(int contragentId);

        /*
        [OperationContract]
        Item[] GetItems(bool showArchive);

        [OperationContract]
        void AddItem(string itemName, bool isRevenue, string description);

        [OperationContract]
        void RemoveItem(int itemId);


        [OperationContract]
        Subitem[] GetSubitems(bool showArchive);

        [OperationContract]
        void AddSubitem(string subitemName, int itemId, string description);

        [OperationContract]
        void RemoveSubitem(int subitemId);


        [OperationContract]
        Taxrate[] GetTaxrates(bool showArchive);

        [OperationContract]
        void AddTaxrate(int taxPercent, string description);

        [OperationContract]
        void RemoveTaxrate(int taxrateId);


        [OperationContract]
        Operation[] GetOperations(bool showArchive);

        [OperationContract]
        void AddOperation(DateTime operationDate, int contragentId, int employeeId, int subitemId, int taxrateId, decimal revenue, decimal earnings);

        [OperationContract]
        void RemoveOperation(int operationId);*/
    }
}
