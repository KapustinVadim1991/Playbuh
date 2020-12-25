using System;
using System.Linq;
using DataAccessLayer.Model;

namespace DataAccessLayer
{
    public class DatabaseAccess
    {

        #region Employee...
        public Employee[] GetEmployees()
        {
            try
            {
                using (PlaybuhEntities context = new PlaybuhEntities())
                {
                    return context.Employee.ToArray();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /*public MsgServerResponce AddEmployee(Employee employee)
        {
            MsgServerResponce validationMessage = Validation(employee);

            if (!validationMessage.IsSucceed)
            {
                return validationMessage;
            }

            try
            {
                using (PlaybuhEntities context = new PlaybuhEntities())
                {
                    if (context.Employee.FirstOrDefault(x=>x.FIO == employee.FIO) != null)
                    {
                        return new MsgServerResponce("Данный сотрудник уже добавлен.");
                    }

                    context.Employee.Add(employee);
                    context.SaveChanges();

                    return validationMessage;
                }
            }
            catch (Exception ex)
            {
                return new MsgServerResponce(ex.Message);
            }
        }*/

        /*public MsgServerResponce RemoveEmployee(Employee employee)
        {
            MsgServerResponce validationMessage = Validation(employee);

            if (!validationMessage.IsSucceed)
            {
                return validationMessage;
            }

            try
            {
                using (PlaybuhEntities context = new PlaybuhEntities())
                {
                    employee = context.Employee.FirstOrDefault(x => x.FIO == employee.FIO);

                    if (employee == null)
                    {
                        return new MsgServerResponce("Данный сотрудник не найден.");
                    }

                    context.Employee.Remove(employee);
                    context.SaveChanges();

                    return new MsgServerResponce($"{employee.FIO} успешно удален.", true);
                }
            }
            catch (Exception ex)
            {
                return new MsgServerResponce(ex.Message);
            }
        }*/

        /*private MsgServerResponce Validation(Employee employee)
        {
            if(employee == null)
            {
                return new MsgServerResponce("Сотрудник не может быть null.");
            }

            if (String.IsNullOrEmpty(employee.FIO))
            {
                return new MsgServerResponce("ФИО сотрудника не может быть пустым.");
            }

            return new MsgServerResponce($"{employee.FIO} успешно добавлен.", true);
        }*/
        #endregion

        /*#region Contragent...
        public Contragent[] GetContragents()
        {
            try
            {
                using (PlaybuhEntities context = new PlaybuhEntities())
                {
                    return context.Contragent.ToArray();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MsgServerResponce AddContragent(Contragent contragent)
        {
            MsgServerResponce validationMessage = Validation(contragent);

            if (!validationMessage.IsSucceed)
            {
                return validationMessage;
            }

            try
            {
                using (PlaybuhEntities context = new PlaybuhEntities())
                {
                    if (context.Contragent.FirstOrDefault(x=>x.title == contragent.title) != null)
                    {
                        return new MsgServerResponce("Данный контрагент уже существует.");
                    }

                    context.Contragent.Add(contragent);
                    context.SaveChanges();

                    return validationMessage;
                }
            }
            catch (Exception ex)
            {
                return new MsgServerResponce(ex.Message);
            }
        }

        public MsgServerResponce RemoveContragent(Contragent contragent)
        {
            MsgServerResponce validationMessage = Validation(contragent);

            if (!validationMessage.IsSucceed)
            {
                return validationMessage;
            }

            try
            {
                using (PlaybuhEntities context = new PlaybuhEntities())
                {
                    contragent = context.Contragent.FirstOrDefault(x => x.title == contragent.title);

                    if (contragent == null)
                    {
                        return new MsgServerResponce("Данный контрагент не найден.");
                    }

                    context.Contragent.Remove(contragent);
                    context.SaveChanges();

                    return new MsgServerResponce($"{contragent.title} успешно удален.", true);
                }
            }
            catch (Exception ex)
            {
                return new MsgServerResponce(ex.Message);
            }
        }

        private MsgServerResponce Validation(Contragent contragent)
        {
            if (contragent == null)
            {
                return new MsgServerResponce("Контрагент не может быть null.");
            }

            if (String.IsNullOrEmpty(contragent.title))
            {
                return new MsgServerResponce("Имя контрагента не может быть пустым.");
            }

            return new MsgServerResponce($"{contragent.title} успешно добавлен.", true);
        }
        #endregion
        
        public MsgServerResponce AddTaxrate(Taxrate taxrate)
        {
            MsgServerResponce validationMessage = Validation(taxrate);

            if (!validationMessage.IsSucceed)
            {
                return validationMessage;
            }

            try
            {
                using (PlaybuhEntities context = new PlaybuhEntities())
                {
                    if (context.Taxrate.Contains(taxrate))
                    {
                        return new MsgServerResponce(false, "Данная налоговая ставка уже существует.");
                    }

                    context.Taxrate.Add(taxrate);
                    context.SaveChanges();

                    return validationMessage;
                }
            }
            catch (Exception ex)
            {
                return new MsgServerResponce(false, ex.Message);
            }
        }

        private MsgServerResponce Validation(Taxrate taxrate)
        {
            if (taxrate == null)
            {
                return new MsgServerResponce(false, "Ставка налога не может быть null.");
            }

            return new MsgServerResponce(true, $"Ставка налога в размере {taxrate.tax_percent}% успешно добавлена.");
        }

        public MsgServerResponce AddSourceOperation(SourceOperation sourceOperation)
        {
            MsgServerResponce validationMessage = Validation(sourceOperation);
            
            if (!validationMessage.IsSucceed)
            {
                return validationMessage;
            }

            try
            {
                using (PlaybuhEntities context = new PlaybuhEntities())
                {
                    if (context.SourceOperation.Contains(sourceOperation))
                    {
                        return new MsgServerResponce(false, "Данный источник доходов/расходов уже существует.");
                    }

                    context.SourceOperation.Add(sourceOperation);
                    context.SaveChanges();

                    return validationMessage;
                }
            }
            catch (Exception ex)
            {
                return new MsgServerResponce(false, ex.Message);
            }
        }

        private MsgServerResponce Validation(SourceOperation sourceOperation)
        {
            if (sourceOperation == null)
            {
                return new MsgServerResponce(false, "источник доходов/расходов не может быть null.");
            }

            if (String.IsNullOrEmpty(sourceOperation.source_name))
            {
                return new MsgServerResponce(false, "Имя источника доходов/расходов не может быть пустым.");
            }

            return new MsgServerResponce(true, $"Источник доходов/расходов {sourceOperation.source_name} успешно добавлен.");
        }

        public MsgServerResponce AddSubsourceOperation(SubsourceOperation subsourceOperation)
        {
            MsgServerResponce validationMessage = Validation(subsourceOperation);

            if (!validationMessage.IsSucceed)
            {
                return validationMessage;
            }

            try
            {
                using (PlaybuhEntities context = new PlaybuhEntities())
                {
                    if (context.SubsourceOperation.Contains(subsourceOperation))
                    {
                        return new MsgServerResponce(false, "Данная статья доходов/расходов уже существует.");
                    }

                    context.SubsourceOperation.Add(subsourceOperation);
                    context.SaveChanges();

                    return validationMessage;
                }
            }
            catch (Exception ex)
            {
                return new MsgServerResponce(false, ex.Message);
            }
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
        */
        /*public MsgServerResponce AddOperation(Operation operation)
        {
            MsgServerResponce validationMessage = Validation(operation);

            if (!validationMessage.IsSucceed)
            {
                return validationMessage;
            }

            try
            {
                using (PlaybuhEntities context = new PlaybuhEntities())
                {
                    if (context.SubsourceOperation.Contains(subsourceOperation))
                    {
                        return new MsgServerResponce(false, "Данная статья доходов/расходов уже существует.");
                    }

                    context.SubsourceOperation.Add(subsourceOperation);
                    context.SaveChanges();

                    return validationMessage;
                }
            }
            catch (Exception ex)
            {
                return new MsgServerResponce(false, ex.Message);
            }
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
        }*/
    }
}
