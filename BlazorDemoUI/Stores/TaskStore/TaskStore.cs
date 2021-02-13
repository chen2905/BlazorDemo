using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorDemoUI.Stores.TaskStore { 
    public class TaskStore
    {
        
        private TaskState _state;
        private readonly IActionDispatcher actionDispatcher;
        private int _initTaskCount = 0;
        private string _searchTerm = "";
        public TaskStore(IActionDispatcher actionDispatcher)
        {
           
            _state = new TaskState(_initTaskCount);
            _state.SearchTerm = _searchTerm;
            this.actionDispatcher = actionDispatcher;
            this.actionDispatcher.Subscribe(HandleActions);
        }

        ~TaskStore()
        {
            this.actionDispatcher.Unsubscribe(HandleActions);
        }
        private void HandleActions(IAction action)
        {
            switch (action.Name)
            {
                case IncreamentAction.INCREMENT:
                    IncrementCount();
                    break;
                case DecreamentAction.DECREMENT:
                    DecrementCount();
                    break;
                case InitialAction.INITIAL:
                    InitCount(action.InitialValue);
                    break;
                case SetSearchTermAction.SEARCHTERM:
                    SetSearchTerm(action.SearchTerm);
                    break;
                default:
                    break;

            }
        }
        public TaskState GetState()
        {
            return _state;
        }
        private void SetSearchTerm(string iSearchTerm)
        {


            this._state.SearchTerm = iSearchTerm;
            BroadcastStateChange();
        }

        private void InitCount(int taskTotal)
        {
            var count = taskTotal;

            this._state = new TaskState(count);
            BroadcastStateChange();
        }

        private void IncrementCount()
        {
            var count = this._state.Count;
            count++;
            this._state = new TaskState(count);
            BroadcastStateChange(); 
        }
        
        private void DecrementCount()
        {
            var count = this._state.Count;
            count--;
            this._state = new TaskState(count);
            BroadcastStateChange();
        }

        #region observerble/listener
        private Action _listeners;
     

        public void AddStateChangeListeners (Action listener)
        {

            _listeners += listener;
        }
        public void RemoveStateChangeListeners (Action listener)
        {
            _listeners -= listener;
        }

        private void BroadcastStateChange()
        {
            _listeners.Invoke();
        }
        #endregion
    }
}
