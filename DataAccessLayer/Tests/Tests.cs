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
            Assert.AreEqual(new MsgServerResponce("Данный сотрудник уже добавлен."), dal.AddEmployee(new Employee("Вадим")));
            Assert.AreEqual(new MsgServerResponce("ФИО сотрудника не может быть пустым."), dal.AddEmployee(new Employee("")));
            Assert.AreEqual(new MsgServerResponce("Сотрудник не может быть null."), dal.AddEmployee(null));
            Assert.AreEqual(new MsgServerResponce("TestUser успешно добавлен.", true), dal.AddEmployee(new Employee("TestUser")));
        }

        [Test]
        public void TestRemoveEmployee()
        {
            var dal = new DatabaseAccess();
            Assert.AreEqual(new MsgServerResponce("TestUser успешно удален.", true), dal.RemoveEmployee(new Employee("TestUser")));
            Assert.AreEqual(new MsgServerResponce("Данный сотрудник не найден."), dal.RemoveEmployee(new Employee("Somebody")));
        }

        [Test]
        public void TestAddContragent()
        {
            var dal = new DatabaseAccess();
            Assert.AreEqual(new MsgServerResponce("Данный контрагент уже существует."), dal.AddContragent(new Contragent("Google")));
            Assert.AreEqual(new MsgServerResponce("Имя контрагента не может быть пустым."), dal.AddContragent(new Contragent("")));
            Assert.AreEqual(new MsgServerResponce("Контрагент не может быть null."), dal.AddContragent(null));
            Assert.AreEqual(new MsgServerResponce("TestContragent успешно добавлен.", true).Message, dal.AddContragent(new Contragent("TestContragent")).Message);
        }

        [Test]
        public void TestRemoveContragent()
        {
            var dal = new DatabaseAccess();
            Assert.AreEqual(new MsgServerResponce("Данный контрагент не найден."), dal.RemoveContragent(new Contragent("Hoohle")));
            Assert.AreEqual(new MsgServerResponce("TestContragent успешно удален.", true), dal.RemoveContragent(new Contragent("TestContragent")));
        }
    }
}
