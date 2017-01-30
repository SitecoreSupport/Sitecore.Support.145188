using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Mvc.Diagnostics;
using Sitecore.Mvc.Presentation;
using System.IO;
using Sitecore.Diagnostics;

namespace Sitecore.Support.Mvc.Pipelines.Response.RenderRendering
{
    public class PageModeRenderingErrorStrategy : Sitecore.Mvc.Pipelines.Response.RenderRendering.PageModeRenderingErrorStrategy, Sitecore.Mvc.Pipelines.Response.RenderRendering.IRendererErrorStrategy
    {
        public bool HandleError(Renderer renderer, Exception ex, TextWriter writer)
        {
            Assert.IsNotNull(renderer, "renderer");
            Assert.IsNotNull(ex, "ex");
            Assert.IsNotNull(writer, "writer");
            ExceptionWrapper exw = ex as ExceptionWrapper;
            if (exw != null)
            {
                ex = exw.Exception;
            }
            return base.HandleError(renderer, ex, writer);
        }
    }
}