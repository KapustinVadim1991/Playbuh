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
                    if (!Validation(employee))
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

        public MsgServerResponce AddSourceOperation(SourceOperation sourceOperation)
        {
            try
            {
                using (PlaybuhEntities context = new PlaybuhEntities())
                {
                    if (!Validation(sourceOperation))
                    {
                        return new MsgServerResponce(false, "Имя источника доходов/расходов не может быть пустым.");
                    }

                    context.SourceOperation.Add(sourceOperation);
                    context.SaveChanges();
                    
                    return new MsgServerResponce(true, $"Источник доходов/расходов {sourceOperation.source_name} успешно добавлен.");
                }
            }
            catch (Exception ex)
            {
                return new MsgServerResponce(false, ex.Message);
            }
        }

        public MsgServerResponce AddSubsourceOperation(SubsourceOperation subsourceOperation)
        {
            try
            {
                using (PlaybuhEntities context = new PlaybuhEntities())
                {
                    MsgServerResponce serverResponce = Validation(subsourceOperation);
                    
                    context.SubsourceOperation.Add(subsourceOperation);
                    context.SaveChanges();

                    return serverResponce;
                }
            }
            catch (Exception ex)
            {
                return new MsgServerResponce(false, ex.Message);
            }
        }

        private bool Validation(Employee employee)
        {
            return !String.IsNullOrEmpty(employee.FIO);
        }

        private bool Validation(SourceOperation sourceOperation)
        {
            return !String.IsNullOrEmpty(sourceOperation.source_name);
        }

        private MsgServerResponce Validation(SubsourceOperation subsourceOperation)
        {
            if (String.IsNullOrEmpty(subsourceOperation.subsource_name))
            {
                return new MsgServerResponce(false, "Имя статьи расходов/доходов не может быть пустым.");
            }
            if (subsourceOperation.SourceOperation == null) 
            {
                return new MsgServerResponce(false, "Выберите источник расходов/доходов."); 
            }

            return new MsgServerResponce(true, $"Статья расходов/доходов {subsourceOperation.subsource_name} добавлена");
        }
    }
}
