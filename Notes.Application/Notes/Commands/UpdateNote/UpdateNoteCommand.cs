﻿using MediatR;
using System;

namespace Notes.Application.Notes.Commands.UpdateNote
{
    internal class UpdateNoteCommand : IRequest
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }

    }
}
