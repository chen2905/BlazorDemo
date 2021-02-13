using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class TaskData : ITaskData
    {
        private readonly ISqlDataAccess _db;

        public TaskData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<TaskModel>> GetTask()
        {
            string sql = "exec dbo.stp_BlazorTask_All";

            return _db.LoadData<TaskModel, dynamic>(sql, new { });
        }

        public Task InsertTask(TaskModel task)
        {
            string sql = @"EXEC sti_Insert_blazor_task @Task, @xPersonID;";

            return _db.SaveData(sql, task);
        }

        public Task UpdateTask(TaskModel task)
        {
            string sql = @"sti_Update_Blazor_Task @Task, @xPersonID, @IsComplete,@TaskStatus, @Id";

            return _db.SaveData(sql, task);
        }
    }
}

