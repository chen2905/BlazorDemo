using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface ITaskData
    {
        Task<List<TaskModel>> GetTask();
        Task InsertTask(TaskModel task);

        Task UpdateTask(TaskModel task);
    }
}