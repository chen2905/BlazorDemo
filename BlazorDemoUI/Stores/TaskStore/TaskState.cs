using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoUI.Stores.TaskStore
{
    public class TaskState
    {

        public int Count { get; set; }
        public string SearchTerm { get; set; }
        public TaskState(int count)
        {
            Count = count;
        }
    }
}
