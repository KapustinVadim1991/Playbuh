using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Model;

namespace DataAccessLayer.Tests
{
    class Tests
    {
        [Test]
        public void TestAddEmployee()
        {
            var dal = new DatabaseAccess();

            try
            {
                dal.AddEmployee(new Employee("Вадим", "Капустин", "Викторович"));
            }
            catch(ArgumentException ex)
            {
                Assert.AreEqual("Данный сотрудник уже добавлен.", ex.Message);
            }

            try
            {
                dal.AddEmployee(new Employee("", "Капустин", "Викторович"));
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

            //try
            //{
            //    dal.AddEmployee(new Employee("TestUser", "sdf", "sdf"));
            //}
            //catch (Exception e)
            //{
            //    throw e;
            //}
        }

        [Test]
        public void TestRemoveEmployee()
        {
            var dal = new DatabaseAccess();

            try
            {
                dal.RemoveEmployee(new Employee("Игорь", "Капустин", "Викторович"));
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Данный сотрудник не найден.", ex.Message);
            }

            //try
            //{
            //    dal.RemoveEmployee(new Employee("TestUser", "sdf", "sdf"));
            //}
            //catch (Exception e)
            //{
            //    throw e;
            //}
        }

        /*[Test]
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
        }*/
    }
}
