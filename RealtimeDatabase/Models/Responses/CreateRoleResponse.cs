﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace RealtimeDatabase.Models.Responses
{
    class CreateRoleResponse : ResponseBase
    {
        public Dictionary<string, object> NewRole { get; set; }

        public IEnumerable<IdentityError> IdentityErrors { get; set; }
    }
}