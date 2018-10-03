﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPro.ViewComponents
{
    public class SimpleTypeViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string vm)
        {
            return View<string>(vm);
        }
    }
}
