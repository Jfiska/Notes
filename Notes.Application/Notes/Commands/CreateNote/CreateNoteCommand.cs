﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Notes.Application.Notes.Commands.CreateNote
{
    internal class CreateNoteCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }
        public string Title {  get; set; }
        public string Details { get; set; }
    }
}
