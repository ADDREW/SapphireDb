﻿using System;

namespace SapphireDb.Command.Stream
{
    public class CompleteStreamCommand : CommandBase
    {
        public Guid StreamId { get; set; }

        public int Index { get; set; }

        public bool Error { get; set; }
    }
}