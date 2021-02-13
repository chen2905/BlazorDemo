using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoUI.Stores.TaskStore
{
    public class DecreamentAction :IAction
    {
        public const string DECREMENT = "DECREMENT";

        public string Name => DECREMENT;
        
        public int InitialValue { get; set; }

        public string SearchTerm { get; }
    }
}
