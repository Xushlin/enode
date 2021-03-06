﻿using ENode.Commanding;
using ENode.Infrastructure;
using NoteSample.Commands;
using NoteSample.Domain;

namespace NoteSample.CommandHandlers
{
    [Component]
    public class CreateNoteCommandHandler : ICommandHandler<CreateNote>
    {
        public void Handle(ICommandContext context, CreateNote command)
        {
            context.Add(new Note(command.NoteId, command.Title));
        }
    }
}
