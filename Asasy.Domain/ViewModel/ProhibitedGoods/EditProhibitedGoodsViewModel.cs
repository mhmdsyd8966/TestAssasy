﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asasy.Domain.ViewModel.ProhibitedGoods
{
    public class EditProhibitedGoodsViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "فضلا ادخل الاسم بالعربيه")]
        public string NameAr { get; set; }
        [Required(ErrorMessage = "فضلا ادخل الاسم بالانجليزيه")]
        public string NameEn { get; set; }
        [Required(ErrorMessage = "فضلا ادخل الوصف بالعربيه")]
        public string DescriptionAr { get; set; }
        [Required(ErrorMessage = "فضلا ادخل الوصف بالانجليزيه")]
        public string DescriptionEn { get; set; }
    }
}
