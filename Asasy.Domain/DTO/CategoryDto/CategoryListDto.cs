﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asasy.Domain.DTO.CategoryDto
{
    public class CategoryListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; } = "";
    }
}
