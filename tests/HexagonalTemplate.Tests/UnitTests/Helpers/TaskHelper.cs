using HexagonalTemplate.Domain.Tasks;
using HexagonalTemplate.Domain.Tasks.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace HexagonalTemplate.Tests.UnitTests.Helpers
{
    public static class TaskHelper
    {
        public static Task GetTask()
        {
            return new Task()
            {
                TaskId = new TaskId(Guid.NewGuid()),
                Summary = new Summary("Summary"),
                Description = new Description("Description")
            };
        }

        public static IEnumerable<Task> GetTasks()
        {
            return new List<Task>()
            {
                GetTask()
            };
        }

    }
}
