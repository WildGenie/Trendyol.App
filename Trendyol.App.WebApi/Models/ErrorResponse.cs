﻿using Trendyol.App.Domain.Responses;

namespace Trendyol.App.WebApi.Models
{
    public class ErrorResponse : BaseResponse
    {
        public string Message { get; set; }
    }
}
