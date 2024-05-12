﻿using HexagonalTemplate.Domain.Tasks;
using HexagonalTemplate.Domain.Tasks.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;


/*
 * Factories are concerned with creating new entities and value objects. 
 * They also validate the invariants for the newly created objects.
 * 
 * This is the EntityFactory, which creates new instances of Entities 
 * and Aggregate Roots.)
 */

namespace HexagonalTemplate.Infrastructure.Factories
{
    public class EntityFactory : ITaskFactory
    {
        public Domain.Tasks.Task CreateTaskInstance(Summary summary, Description description)
        {
            return new TaskFactory(summary, description);
        }
    }
}
