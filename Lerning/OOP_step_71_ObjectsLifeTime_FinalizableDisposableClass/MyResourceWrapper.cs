using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_71_ObjectsLifeTime_FinalizableDisposableClass
{
    public class MyResourceWrapper : IDisposable
    {
        private bool dispozed = false;

        ~MyResourceWrapper()
        {
            Console.Beep();
            //Использольвать для очистки неуправляемых ресурсов
            //++Не++ вызывать Dispose на неуправляемых ресурсах
            CleanUp(false); //false означает что очистку запустил сборщик мусора
        }

        public void Dispose()
        {
            //очистить неуправляемые ресурсы
            //вызвать Dispose для других неуправляемых объектов,
            //содержащихся внутри
            CleanUp(true); //true означает что очистку запустил пользователь
            //Если пользователь вызвал Dispose то финализация
            //не нужна, поэтому подавить ее
            GC.SuppressFinalize(this);
        }

        private void CleanUp(bool disposing)
        {
            //проверить не выполнилось ли уже освобождение
            if (!this.dispozed)
            {
                if (disposing)
                {
                    //освободить управляемые ресурсы
                }
                //очистить управляемые ресурсы
                dispozed = true;
            }
        }
    }
}
