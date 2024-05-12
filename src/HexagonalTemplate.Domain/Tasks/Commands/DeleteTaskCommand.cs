using System;
using System.Collections.Generic;
using System.Text;

namespace HexagonalTemplate.Domain.Tasks.Commands
{
    public class DeleteTaskCommand : TaskCommand
    {
        public DeleteTaskCommand(Guid id)
        {
            Id = id;
        }
    }
}
