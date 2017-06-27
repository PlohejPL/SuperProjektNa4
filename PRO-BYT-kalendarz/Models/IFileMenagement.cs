using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO_BYT_kalendarz
{
    public interface IDbConnectionMenagement<T> where T : class
    {
        T getTask(int taskId);
        T saveTask(T task);
        IEnumerable<T> getAllTasks();
        void editTask(T task);
        void deleteTask(T task);
        void deleteTask(int taskId);
        void Dispose();
    }
}
