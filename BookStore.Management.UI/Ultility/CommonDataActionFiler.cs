﻿using BookStore.Management.Domain.Setting;
using BookStore.Management.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BookStore.Management.UI.Ultility
{
    public class CommonDataActionFiler : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var carts = context.HttpContext.Session.Get<List<CartModel>>(CommonConstant.CartSessionName);

            if (carts is not null)
            {
                var controller = context.Controller as Controller;

                controller.ViewData["NumberCart"] = carts.Count;
            }
        }
    }
}
