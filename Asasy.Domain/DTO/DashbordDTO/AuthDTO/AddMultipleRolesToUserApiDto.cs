﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asasy.Domain.DTO.DashbordDTO.AuthDTO
{
    public class AddMultipleRolesToUserApiDto
    {
        public string userId { get; set; }
        public List<string> rolesId { get; set; }
    }
}
