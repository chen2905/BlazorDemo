using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoUI.Stores
{
    public class ActionDispatcher :IActionDispatcher
    {
        private Action<IAction> _registerActionHandlers;

        public void Subscribe(Action<IAction> actionHandler)
        {
            _registerActionHandlers += actionHandler;
        }

        public void Unsubscribe(Action<IAction> actionHandler)
        {
            _registerActionHandlers -= actionHandler;
        }

        public void Dispatch(IAction action)
        {
            _registerActionHandlers?.Invoke(action);
        }
    }
}
