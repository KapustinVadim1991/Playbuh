using NUnit.Framework;
using System;
using DataAccessLayer.Model;

namespace DataAccessLayer.Tests
{
    class Tests
    {
        #region Test employees
        [Test]
        public void TestAddEmployee()
        {
            var dal = new DatabaseAccess();

            try
            {
                dal.AddEmployee(new Employee("Вадим", "Капустин", "Викторович", null));
            }
            catch(ArgumentException ex)
            {
                Assert.AreEqual("Данный сотрудник уже добавлен.", ex.Message);
            }

            try
            {
                dal.AddEmployee(new Employee("", "Капустин", "Викторович", null));
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("ФИО сотрудника не может быть пустым.", ex.Message);
            }

            try
            {
                dal.AddEmployee(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Сотрудник не может быть null.", ex.Message);
            }
        }

        [Test]
        public void TestRemoveEmployee()
        {
            var dal = new DatabaseAccess();

            try
            {
                // Id начинается с единицы, проверяем удаление несуществующей записи в таблице
                dal.RemoveEmployee(999);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Данный сотрудник не найден.", ex.Message);
            }
        }
        #endregion

        #region Test contragents
        [Test]
        public void TestAddContragent()
        {
            var dal = new DatabaseAccess();

            try
            {
                dal.AddContragent(new Contragent("Google"));
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Данный контрагент уже добавлен.", ex.Message);
            }

            try
            {
                dal.AddContragent(new Contragent(""));
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Наименование контрагента не может быть пустым.", ex.Message);
            }

            try
            {
                dal.AddContragent(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Контрагент не может быть null.", ex.Message);
            }
        }

        [Test]
        public void TestRemoveContragent()
        {
            var dal = new DatabaseAccess();

            try
            {
                // Id начинается с единицы, проверяем удаление несуществующей записи в таблице
                dal.RemoveContragent(0); 
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Данный контрагент не найден.", ex.Message);
            }
        }
        #endregion

        #region Test items
        [Test]
        public void TestAddItem()
        {
            var dal = new DatabaseAccess();

            try
            {
                dal.AddItem(new Item("Реклама", true, "Доход с рекламы"));
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Данная статья уже добавлена.", ex.Message);
            }

            try
            {
                dal.AddItem(new Item("", true, null));
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Наименование статьи не может быть пустым.", ex.Message);
            }

            try
            {
                dal.AddItem(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Статья не может быть null.", ex.Message);
            }
        }

        [Test]
        public void TestRemoveItem()
        {
            var dal = new DatabaseAccess();

            try
            {
                // Id начинается с единицы, проверяем удаление несуществующей записи в таблице
                dal.RemoveItem(0);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Данная статья не найдена.", ex.Message);
            }
        }
        #endregion

        #region Test subitems
        [Test]
        public void TestAddSubitem()
        {
            var dal = new DatabaseAccess();

            try
            {
                dal.AddSubitem(new Subitem("AdMob", 1, "fancyfix96"));
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Данная подстатья уже добавлена.", ex.Message);
            }

            try
            {
                dal.AddSubitem(new Subitem("", 1, null));
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Наименование подстатьи не может быть пустым.", ex.Message);
            }

            try
            {
                dal.AddSubitem(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Подстатья не может быть null.", ex.Message);
            }
        }

        [Test]
        public void TestRemoveSubitem()
        {
            var dal = new DatabaseAccess();

            try
            {
                // Id начинается с единицы, проверяем удаление несуществующей записи в таблице
                dal.RemoveSubitem(0);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Данная подстатья не найдена.", ex.Message);
            }
        }
        #endregion

        #region Test taxrates
        [Test]
        public void TestAddTaxrate()
        {
            var dal = new DatabaseAccess();

            try
            {
                dal.AddTaxrate(new Taxrate(0, null));
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Данная налоговая ставка уже добавлена.", ex.Message);
            }

            try
            {
                dal.AddTaxrate(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Налоговая ставка не может быть null.", ex.Message);
            }
        }

        [Test]
        public void TestRemoveTaxrate()
        {
            var dal = new DatabaseAccess();

            try
            {
                // Id начинается с единицы, проверяем удаление несуществующей записи в таблице
                dal.RemoveTaxrate(0);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Данная налоговая ставка не найдена.", ex.Message);
            }
        }
        #endregion
    }
}
