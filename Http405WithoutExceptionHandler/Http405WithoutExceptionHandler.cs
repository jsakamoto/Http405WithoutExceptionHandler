using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Toolbelt.Web
{
    public class Http405WithoutExceptionHandler : IHttpHandler
    {
        public bool IsReusable { get { return true; } }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.StatusCode = 405;
        }
    }
}
