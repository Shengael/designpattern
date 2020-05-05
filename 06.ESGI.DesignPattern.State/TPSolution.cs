using System;
using System.Collections.Generic;

namespace _06.ESGI.DesignPattern.State
{

    public class Task
    {

        public ITaskState State = new TodoState();
        
        public string Start()
        {
            return State.Start(this);
        }
        public string Close()
        {
            return State.Close(this);
        }
    }

    public class TodoState: ITaskState
    {
        public string Start(Task task)
        {
            task.State = new InProgressState();
            return "TODO -> IN PROGRESS";
            // return new InProgressState();
        }

        public string Close(Task task)
        {
            return "INVALID TRANSITION";
        }
    }
    
    public class InProgressState: ITaskState
    {
        public string Start(Task task)
        {
            return "INVALID TRANSITION";
        }

        public string Close(Task task)
        {
            task.State = new ClosedState();
            return "IN PROGRESS -> CLOSED";
        }
    }

    public class ClosedState: ITaskState
    {
        public string Start(Task task)
        {
            return "INVALID TRANSITION";
        }

        public string Close(Task task)
        {
            return "INVALID TRANSITION";
        }
    }

    public interface ITaskState
    {
        string Start(Task task);
        string Close(Task task);
    }
  
}
