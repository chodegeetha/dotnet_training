using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_mvc_withado1.Filter
{
    
        public class LogExceptionFilterAttribute : FilterAttribute, IExceptionFilter
        {
            private readonly ILog _logger;

            public LogExceptionFilterAttribute()
            {
                _logger = LogManager.GetLogger(typeof(LogExceptionFilterAttribute));
            }

            public void OnException(ExceptionContext filterContext)
            {
                if (filterContext == null)
                {
                    throw new ArgumentNullException(nameof(filterContext));
                }

                _logger.Error("An unhandled exception occurred.", filterContext.Exception);
            }
        }

}