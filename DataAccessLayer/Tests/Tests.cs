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
            var employee = new Employee("Вадим");
            var dal = new DatabaseAccess();
            Assert.AreEqual("Данный сотрудник уже добавлен", dal.AddNewEmploye(employee).MessageText);
        }
    }
}
