using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EmployeeCreator
    {

        public void AddNewEmploye(string fio)
        {
            using(PLAYBUHEntities context = new PLAYBUHEntities())
            {
                context.EMPLOYEES.Add(
                    new EMPLOYEES { FIO = fio }
                    );

                context.SaveChanges();
            }
        }
    }
}
