﻿using Microsoft.EntityFrameworkCore;
using onlinelearningbackend.Data;
using onlinelearningbackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onlinelearningbackend.Manager
{
    public class TaskSolutionManager : ITaskSolutionManager
    {
        ApplicationDbContext DB;
        public TaskSolutionManager(ApplicationDbContext _DB)
        {
            DB = _DB;
        }

        public IEnumerable<TaskSolution> AddTaskByStudent( string StudentId,int TaskId, int CourseId,TaskSolution newTaskSolution)
        {
            var TaskSolution = DB.TaskSolutions.FromSqlRaw("EXEC dbo.usp_TaskSolutions_Insert {0}",
                                                        StudentId,
                                                        TaskId, 
                                                        CourseId,
                                                        newTaskSolution.TaskSolutionURL).ToList<TaskSolution>();
            return TaskSolution;
        }

        public IEnumerable<TaskSolution> DeleteTaskSolutionByTaskId(int TaskSolutionId)
        {
            var TaskSolution = DB.TaskSolutions.FromSqlRaw("EXEC dbo.usp_TaskSolutions_Delete {0}", TaskSolutionId).ToList<TaskSolution>();
            return TaskSolution;
        }

        public IEnumerable<TaskSolution> EditTaskSolution(string StudentId, TaskSolution newTaskSolution)
        {
            var TaskSolution = DB.TaskSolutions.FromSqlRaw("EXEC dbo.usp_TaskSolutions_Update {0}",
                                                     newTaskSolution.TaskSolutionId,
                                                     StudentId,
                                                     newTaskSolution.TaskSolutionURL).ToList<TaskSolution>();
            return TaskSolution;
        }

        public TaskSolution GetTaskSolutionById(int TaskSolutionId)
        {
            throw new NotImplementedException();
            //dbo.usp_TaskSolutions_Select
        }
    }
}
