using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DatabaseAccess
    {
        public MsgServerResponce AddNewEmploye(Employee employee)
        {
            try
            {
                using (PlaybuhEntities context = new PlaybuhEntities())
                {
                    if (!ValidationEmployee(employee))
                    {
                        return new MsgServerResponce(false, "ФИО сотрудника не может быть пустым.");
                    }

                    context.Employee.Add(employee);
                    context.SaveChanges();

                    return new MsgServerResponce(true, $"{employee.FIO} успешно добавлен.");
                }
            }
            catch (Exception ex)
            {
                return new MsgServerResponce(false, ex.Message);
            }
        }


        private bool ValidationEmployee(Employee employee)
        {
            return !String.IsNullOrEmpty(employee.FIO);
        }
    }
}
