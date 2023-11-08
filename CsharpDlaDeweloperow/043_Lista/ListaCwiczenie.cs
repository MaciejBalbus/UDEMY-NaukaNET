using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Lista
{
    public class TaskManager
    {
        private List<string> tasks = new List<string>();

        public void AddTask(string task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(string task)
        {
            tasks.RemoveAll(x => x == task);
        }

        public List<string> GetTasks()
        {
            return tasks;
        }
    }




}
