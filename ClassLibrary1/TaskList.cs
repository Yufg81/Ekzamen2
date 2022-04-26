using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TaskList
    {
        private string Name;
        private List<Task> tasks;

        public TaskList(string Name)
        {
            this.Name = Name;
            tasks = new List<Task>();
        }
        public string GetName(string Name)
        {
            return Name;
        }
        public Task AddTask(Task task)
        {
            tasks.Add(task);
            return task;
        }
        public Task[] GetTask()
        {
            
        }
        
        public void Remove(Task task){
           
         }
        public Task[] GetTasksByToday()
        {

        }
        public Task[] GetTasksByFuture()
        {

        }
        

    }
}
