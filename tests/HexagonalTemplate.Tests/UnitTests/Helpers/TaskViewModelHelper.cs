﻿using HexagonalTemplate.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace HexagonalTemplate.Tests.UnitTests.Helpers
{
    public static class TaskViewModelHelper
    {
        public static TaskViewModel GetTaskViewModel()
        {
            return new TaskViewModel
            {
                Id = Guid.NewGuid().ToString(),
                Summary = "Summary",
                Description = "Description"
            };
        }
    }
}
