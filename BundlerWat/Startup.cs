using BundlerMiddleware;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace BundlerWat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            BundlerRoutes.Routes.FromVirtualPath("/", "~/default.html");
            app.UseBundlerMiddlewareForIIS();
        }
    }
}