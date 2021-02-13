using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoUI.Stores.TaskStore
{
   

    public class SetSearchTermAction : IAction
    {
        public const string SEARCHTERM = "SEARCHTERM";

        public string Name => SEARCHTERM;
        public int InitialValue { get; set; }
        public string SearchTerm { get; set; }
    }
}
