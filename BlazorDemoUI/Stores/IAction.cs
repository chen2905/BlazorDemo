using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoUI.Stores
{
  public  interface IAction
    {
        public string Name { get; }

        public int InitialValue { get; }
        public string SearchTerm { get; }
    }
}
