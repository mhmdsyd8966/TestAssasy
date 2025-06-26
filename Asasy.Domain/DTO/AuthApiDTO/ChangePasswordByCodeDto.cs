﻿using Asasy.Domain.Common.Helpers;
using Asasy.Domain.Enums;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asasy.Domain.DTO.AuthApiDTO
{
    public class ChangePasswordByCodeDto
    {
        public string userId { get; set; }
        public int code { get; set; }
        [MinLength(6)]
        public string newPassword { get; set; }

        public string lang { get; set; } = "ar";

       
    }
    public class ChangePasswordByCodeDtoValidator : AbstractValidator<ChangePasswordByCodeDto>
    {
        public ChangePasswordByCodeDtoValidator(IStringLocalizer<ChangePasswordByCodeDto> localizer)
        {

            RuleFor(x => x.code).NotEmpty()
                .WithMessage(e => AAITHelper.HelperMsg.creatMessage(e.lang, Helper.getFileTranslate(Lang.Translate.ar, "code"), Helper.getFileTranslate(Lang.Translate.en, "code")));

            RuleFor(x => x.newPassword).NotEmpty()
                .WithMessage(e => AAITHelper.HelperMsg.creatMessage(e.lang, Helper.getFileTranslate(Lang.Translate.ar, "newPassword"), Helper.getFileTranslate(Lang.Translate.en, "newPassword")))
                        .Length(6, 100)
                        .WithMessage(e => AAITHelper.HelperMsg.creatMessage(e.lang, Helper.getFileTranslate(Lang.Translate.ar, "length"), Helper.getFileTranslate(Lang.Translate.en, "length")));

        }

    }
}
