using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoUI.Stores.TaskStore
{
    public class InitialAction :IAction
    {
        public const string INITIAL = "INITIAL";

        public string Name => INITIAL;

        //private int _intialValue;

        public int InitialValue { get; set; }

        public string SearchTerm { get; set; }



    }
}
