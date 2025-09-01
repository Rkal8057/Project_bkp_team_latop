using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;

namespace Web_API.Validations
{
    public class CommonValidation: ActionFilterAttribute
    {
        //public override void OnActionExecuting(ActionExecutingContext context)
        //{
        //    var modelState = context.ModelState;
        //    string message = "";

        //    if (!modelState.IsValid)
        //    {
        //        message = "<ol>";
        //        foreach (var key in modelState.Keys)
        //        {
        //            var state = modelState[key];
        //            if (state.Errors.Any())
        //            {
        //                message += "<li>" + state.Errors.First().ErrorMessage + "</li>";
        //            }
        //        }
        //        message += "</ol>";

        //        context.Result = new JsonResult(new { Result = false, Message = message })
        //        {
        //            StatusCode = (int)System.Net.HttpStatusCode.BadRequest
        //        };
        //    }

        //    base.OnActionExecuting(context);
        //}


        public class ValidationActionFilterAttribute : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext context)
            {
                Console.WriteLine(context);
                if (!context.ModelState.IsValid)
                {
                    var errors = context.ModelState.Values
                        .SelectMany(v => v.Errors)
                        .Select(e => e.ErrorMessage)
                        .ToList();

                    var result = new
                    {
                        Result = false,
                        Message = string.Join("\n", errors)
                    };

                    context.Result = new BadRequestObjectResult(result);
                }

                base.OnActionExecuting(context);
            }
        }

    }
}
