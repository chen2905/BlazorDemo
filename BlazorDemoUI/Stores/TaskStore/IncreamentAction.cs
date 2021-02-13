using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoUI.Stores.TaskStore
{
    public class IncreamentAction : IAction
    {
        public const string INCREMENT = "INCREMENT";

        public string Name => INCREMENT;
        //private int _intialValue;

        public int InitialValue { get; set; }

        public string SearchTerm { get; }
    }
}
