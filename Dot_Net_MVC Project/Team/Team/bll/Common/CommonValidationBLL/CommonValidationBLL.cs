
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CommonValidation
{
    public class CommonValidationBLL
    {
        public class ValidationActionFilterAttribute : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                var modelState = filterContext.Controller.ViewData.ModelState;
                var valueProvider = filterContext.Controller.ValueProvider;
                var keysWithNoIncomingValue = modelState.Keys.Where(x => !valueProvider.ContainsPrefix(x));
                foreach (var key in keysWithNoIncomingValue)
                    modelState[key].Errors.Clear();
                string Message = "";
                // modelState.Remove("Status");
                if (!modelState.IsValid)
                {
                    Message = "<ol>";
                    foreach (var key in modelState.Keys)
                    {
                        var state = modelState[key];
                        if (state.Errors.Any())
                        {
                            Message += "<li>" + state.Errors.First().ErrorMessage + "</li>";
                        }
                    }
                    Message += "</ol>";

                    var result = new JsonResult();
                    result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
                    result.ContentType = "application/json";
                    result.Data = new { Result = false, Message = Message };
                    filterContext.Result = result;
                }

                base.OnActionExecuting(filterContext);
            }
        }


    }
}