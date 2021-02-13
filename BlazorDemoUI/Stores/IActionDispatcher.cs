using System;

namespace BlazorDemoUI.Stores
{
    public interface IActionDispatcher
    {
        void Dispatch(IAction action);
        void Subscribe(Action<IAction> actionHandler);
        void Unsubscribe(Action<IAction> actionHandler);
    }
}