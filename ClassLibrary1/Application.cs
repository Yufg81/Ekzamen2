using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// GetApplication - возвращает ссылку на экземпляр application
/// </summary>
namespace ClassLibrary1
{
    public class Application
    {
        public Application application;
        public List<TaskList> taskList;

        public Application GetApplication()
        {
            if (application == null)
                application = new Application();
            return application;
                 
           
        }
        public TaskList CreateTaskList(string name)
        {

        }
        public string GetTasksListNames()
        {
           
        }
        public TaskList GetTaskListByName(string name)
        {

        }
       public Task[] GetTasksByToday()
        {

        }
        public Task[] GetTasksByFuture()
        {

        } 
              
    }
}
