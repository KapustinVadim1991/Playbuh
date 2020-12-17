using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DataAccessLayer.Tests
{
    class Tests
    {
        [Test]
        public void TestAddEmployee()
        {
            var dal = new DatabaseAccess();
            Assert.AreEqual("Данный сотрудник уже добавлен", dal.AddEmployee(new Employee("Вадим")).Message);
            Assert.AreEqual("ФИО сотрудника не может быть пустым", dal.AddEmployee(new Employee("")).Message);
            Assert.AreEqual("Сотрудник не может быть null.", dal.AddEmployee(null).Message);
            Assert.AreEqual("TestUser успешно добавлен.", dal.AddEmployee(new Employee("TestUser")).Message);
        }

        [Test]
        public void TestDeleteEmployee()
        {
            var dal = new DatabaseAccess();
            Assert.AreEqual("TestUser успешно удален.", dal.RemoveEmployee(new Employee("TestUser")).Message);
            Assert.AreEqual("Данный сотрудник не найден.", dal.RemoveEmployee(new Employee("Somebody")).Message);
        }
    }
}
