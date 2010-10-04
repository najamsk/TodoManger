using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TodoDAL
{
    public interface ITaskGroups {
        IEnumerable<TaskGroup> GetTaskGroup();       
        void Add(TaskGroup taskGroup);
        void SaveChanges();
    }
    public interface ITasks { }

    public class TaskGroupRepository : ITaskGroups
    {
        TodoContainer db;
        public TaskGroupRepository()
        {
            db = new TodoContainer();
        }

        public IEnumerable<TaskGroup> GetTaskGroup()
        {
            //pablo:not allowing query composition - i would research and follow rob cornery who is favoring query composition
            return db.TaskGroups.AsEnumerable();
        }
        
        public void Add(TaskGroup taskGroup)
        {
            db.TaskGroups.AddObject(taskGroup);
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}
