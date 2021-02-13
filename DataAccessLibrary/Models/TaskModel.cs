using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
  public  class TaskModel
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public bool IsComplete { get; set; }
        public int xPersonID { get; set; }

        public int TaskStatus { get; set; }
    }
}
