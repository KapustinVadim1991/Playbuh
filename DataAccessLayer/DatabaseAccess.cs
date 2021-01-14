using System;
using System.Data.Entity.Migrations;
using System.Linq;
using DataAccessLayer.Model;

namespace DataAccessLayer
{
    public class DatabaseAccess
    {
        private PlaybuhEntities GetContext()
        {
            return new PlaybuhEntities();
        }

        #region Employee...
        public Employee[] GetEmployees(bool showArchive)
        {
            using (var context = GetContext())
            {
                if (showArchive)
                {
                    return context.Employee.OrderBy(x => x.LastName).ToArray();
                }

                return context.Employee.OrderBy(x => x.LastName)
                                        .Where(y => !y.IsArchive)
                                        .ToArray();
            }
        }

        public void AddEmployee(Employee employee)
        {
            Validation(employee);

            using (var context = GetContext())
            {
                if (context.Employee.FirstOrDefault(x=>x.LastName == employee.LastName 
                                                    && x.FirstName == employee.FirstName 
                                                    && x.MiddleName == employee.MiddleName) != null)
                {
                    throw new ArgumentException("Данный сотрудник уже добавлен.");
                }

                context.Employee.Add(employee);
                context.SaveChanges();
            }            
        }

        public void UpdateEmployee(Employee employee)
        {
            Validation(employee);

            using (var context = GetContext())
            {
                if (context.Employee.FirstOrDefault(x => x.Id == employee.Id) == null)
                {
                    throw new ArgumentNullException("Данный сотрудник не найден.");
                }

                context.Employee.AddOrUpdate(employee);
                context.SaveChanges();
            }
        }

        public void RemoveEmployee(int employeeId)
        {
            using (var context = GetContext())
            {
                Employee employee = context.Employee.FirstOrDefault(x => x.Id == employeeId);

                if (employee == null)
                {
                    throw new ArgumentNullException("Данный сотрудник не найден.");
                }

                employee.IsArchive = true;
                context.SaveChanges();
            }
        }

        private void Validation(Employee employee)
        {
            if(employee == null)
            {
                throw new ArgumentException("Сотрудник не может быть null.");
            }

            if (String.IsNullOrEmpty(employee.LastName) 
                || String.IsNullOrEmpty(employee.FirstName)
                || String.IsNullOrEmpty(employee.MiddleName))
            {
                throw new ArgumentException("ФИО сотрудника не может быть пустым.");
            }
        }
        #endregion

        #region Contragent...
        public Contragent[] GetContragents(bool showArchive)
        {
            using (var context = GetContext())
            {
                if (showArchive)
                {
                    return context.Contragent.OrderBy(x => x.Title).ToArray();
                }

                return context.Contragent.OrderBy(x => x.Title)
                                         .Where(y => !y.IsArchive)
                                         .ToArray();
            }
        }

        public void AddContragent(Contragent contragent)
        {
            Validation(contragent);

            using (var context = GetContext())
            {
                if (context.Contragent.FirstOrDefault(x => x.Title == contragent.Title) != null)
                {
                    throw new ArgumentException("Данный контрагент уже добавлен.");
                }

                context.Contragent.Add(contragent);
                context.SaveChanges();
            }
        }

        public void RemoveContragent(int contragentId)
        {
            using (var context = GetContext())
            {
                Contragent contragent = context.Contragent.FirstOrDefault(x => x.Id == contragentId);

                if (contragent == null)
                {
                    throw new ArgumentNullException("Данный контрагент не найден.");
                }

                contragent.IsArchive = true;
                context.SaveChanges();
            }
        }

        private void Validation(Contragent contragent)
        {
            if (contragent == null)
            {
                throw new ArgumentException("Контрагент не может быть null.");
            }

            if (String.IsNullOrEmpty(contragent.Title))
            {
                throw new ArgumentException("Наименование контрагента не может быть пустым.");
            }
        }
        #endregion Contragent...

        #region Item...
        public Item[] GetItems(bool showArchive)
        {
            using (var context = GetContext())
            {
                if (showArchive)
                {
                    return context.Item.OrderBy(x => x.ItemName).ToArray();
                }

                return context.Item.OrderBy(x => x.ItemName)
                                   .Where(y => !y.IsArchive)
                                   .ToArray();
            }
        }

        public void AddItem(Item item)
        {
            Validation(item);

            using (var context = GetContext())
            {
                if (context.Item.FirstOrDefault(x => x.ItemName == item.ItemName
                                                        && x.IsRevenue == item.IsRevenue
                                                        && x.Description == item.Description) != null)
                {
                    throw new ArgumentException("Данная статья уже добавлена.");
                }

                context.Item.Add(item);
                context.SaveChanges();
            }
        }

        public void RemoveItem(int itemId)
        {
            using (var context = GetContext())
            {
                Item item = context.Item.FirstOrDefault(x => x.Id == itemId);

                if (item == null)
                {
                    throw new ArgumentNullException("Данная статья не найдена.");
                }

                item.IsArchive = true;
                context.SaveChanges();
            }
        }

        private void Validation(Item item)
        {
            if (item == null)
            {
                throw new ArgumentException("Статья не может быть null.");
            }

            if (String.IsNullOrEmpty(item.ItemName))
            {
                throw new ArgumentException("Наименование статьи не может быть пустым.");
            }
        }
        #endregion Item...

        #region Subitem...
        public Subitem[] GetSubitems(bool showArchive)
        {
            using (var context = GetContext())
            {
                if (showArchive)
                {
                    return context.Subitem.OrderBy(x => x.SubitemName).ToArray();
                }

                return context.Subitem.OrderBy(x => x.SubitemName)
                                      .Where(y => !y.IsArchive)
                                      .ToArray();
            }
        }

        public void AddSubitem(Subitem subitem)
        {
            Validation(subitem);

            using (var context = GetContext())
            {
                if (context.Subitem.FirstOrDefault(x => x.SubitemName == subitem.SubitemName
                                                        && x.Description == subitem.Description
                                                        && x.ItemId == subitem.ItemId) != null)
                {
                    throw new ArgumentException("Данная подстатья уже добавлена.");
                }

                context.Subitem.Add(subitem);
                context.SaveChanges();
            }
        }

        public void RemoveSubitem(int subitemId)
        {
            using (var context = GetContext())
            {
                Subitem subitem = context.Subitem.FirstOrDefault(x => x.Id == subitemId);

                if (subitem == null)
                {
                    throw new ArgumentNullException("Данная подстатья не найдена.");
                }

                subitem.IsArchive = true;
                context.SaveChanges();
            }
        }

        private void Validation(Subitem subitem)
        {
            if (subitem == null)
            {
                throw new ArgumentException("Подстатья не может быть null.");
            }

            if (String.IsNullOrEmpty(subitem.SubitemName))
            {
                throw new ArgumentException("Наименование подстатьи не может быть пустым.");
            }
        }
        #endregion Subitem...

        #region Taxrate...
        public Taxrate[] GetTaxrates(bool showArchive)
        {
            using (var context = GetContext())
            {
                if (showArchive)
                {
                    return context.Taxrate.OrderBy(x => x.TaxPercent).ToArray();
                }

                return context.Taxrate.OrderBy(x => x.TaxPercent)
                    .Where(y => !y.IsArchive)
                    .ToArray();
            }
        }

        public void AddTaxrate(Taxrate tax)
        {
            Validation(tax);

            using (var context = GetContext())
            {
                if (context.Taxrate.FirstOrDefault(x => x.TaxPercent == tax.TaxPercent) != null)
                {
                    throw new ArgumentException("Данная налоговая ставка уже добавлена.");
                }

                context.Taxrate.Add(tax);
                context.SaveChanges();
            }
        }

        public void RemoveTaxrate(int taxrateId)
        {
            using (var context = GetContext())
            {
                Taxrate taxrate = context.Taxrate.FirstOrDefault(x => x.Id == taxrateId);

                if (taxrate == null)
                {
                    throw new ArgumentNullException("Данная налоговая ставка не найдена.");
                }

                taxrate.IsArchive = true;
                context.SaveChanges();
            }
        }

        private void Validation(Taxrate tax)
        {
            if (tax == null)
            {
                throw new ArgumentException("Налоговая ставка не может быть null.");
            }
        }
        #endregion Taxrate...

        #region Operations...
        public Operation[] GetOperations(bool showArchive)
        {
            using (var context = GetContext())
            {
                if (showArchive)
                {
                    return context.Operation.OrderByDescending(x => x.CreateDate).ToArray();
                }

                return context.Operation.OrderByDescending(x => x.CreateDate)
                    .Where(y => !y.IsArchive)
                    .ToArray();
            }
        }

        public void AddOperation(Operation operation)
        {
            using (var context = GetContext())
            {
                context.Operation.Add(operation);
                context.SaveChanges();
            }
        }

        public void RemoveOperation(int operationId)
        {
            using (var context = GetContext())
            {
                Operation operation = context.Operation.FirstOrDefault(x => x.Id == operationId);

                if (operation == null)
                {
                    throw new ArgumentNullException("Данная операция не найдена.");
                }

                operation.IsArchive = true;
                context.SaveChanges();
            }
        }
        #endregion Operations...
    }
}
