using System;
using System.Net;
using System.Threading.Tasks;
using Unosquare.Labs.EmbedIO;
using Unosquare.Labs.EmbedIO.Constants;
using Unosquare.Labs.EmbedIO.Modules;

namespace EmbedIOTestProject
{
    public class TestWebServer
    {
        public TestWebServer()
        {
            WebServer server = new WebServer("http://localhost:8080")
                .WithWebApiController<TestWebServerController>();
            server.RunAsync();
        }
    }

    public class TestWebServerController : WebApiController
    {
        [WebApiHandler(HttpVerbs.Get, "/")]
        public Task<bool> GetIndex(WebServer server, HttpListenerContext context)
        {
            return context.StringResponseAsync("Hello There!");
        }
    }
}
