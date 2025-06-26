﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asasy.Domain.DTO.ChatDTO
{
    public class ListUsersMyChatDto
    {
        public int Id { get; set; }
        public int ChatId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string lastMsg { get; set; }
        public string Date { get; set; }
        public string UserImg { get; set; }
        public AdInfoDto adInfo { get; set; }
    }
}
