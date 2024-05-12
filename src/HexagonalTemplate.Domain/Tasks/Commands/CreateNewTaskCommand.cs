﻿namespace HexagonalTemplate.Domain.Tasks.Commands
{
    public class CreateNewTaskCommand : TaskCommand
    {
        public CreateNewTaskCommand(string summary, string description)
        {
            Summary = summary;
            Description = description;
        }
    }
}
