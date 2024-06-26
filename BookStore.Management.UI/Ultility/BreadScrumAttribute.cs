﻿using BookStore.Management.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BookStore.Management.UI.Ultility
{
    public class BreadScrumAttribute :ActionFilterAttribute, IActionFilter
    {
        private readonly string _masterName;
        private readonly string _title;
        
        public BreadScrumAttribute(string title, string masterName = "") 
        {
            _masterName = masterName;
            _title = title;
        }
        
        
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if(context.Controller is Controller controller)
            {
                string controllerName = controller.GetType().Name.Replace("Controller","");

                string path = string.IsNullOrEmpty(_masterName) ? $"{controllerName}" : $"{_masterName}/{controllerName}/{_title}";


                controller.ViewData["Breadscrumb"] = new BreadscrumModel
                {
                    Title = _title,
                    Path = path
                };
            }
        }
    }
}
