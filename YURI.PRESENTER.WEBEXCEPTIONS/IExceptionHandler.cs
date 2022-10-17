﻿using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YURI.PRESENTER.WEBEXCEPTIONS
{
    public interface IExceptionHandler
    {
        Task Handle(ExceptionContext context);    
    }
}
