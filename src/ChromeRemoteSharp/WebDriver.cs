using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using WebSocketSharp;

namespace ChromeRemoteSharp
{
    /// <summary>
    /// https://chromedevtools.github.io/devtools-protocol/
    /// </summary>
    public partial class WebDriver
    {
        WebSocket ws;
        long id;
        readonly Dictionary<long, JObject> cmds;

        public TimeSpan TimeCheckResponse { get; set; } = new TimeSpan(0, 0, 0, 0, 100);

        public DomDomain.DomDomain Dom { get; }
        public BrowserDomain.BrowserDomain Browser { get; }
        public PageDomain.PageDomain Page { get; }

        public WebDriver(Uri url)
        {
            this.Dom = new DomDomain.DomDomain(this);
            this.Browser = new BrowserDomain.BrowserDomain(this);
            this.Page = new PageDomain.PageDomain(this);

            ws = new WebSocket(url.ToString());
            ws.OnClose += Ws_OnClose;
            ws.OnError += Ws_OnError;
            ws.OnOpen += Ws_OnOpen;
            ws.OnMessage += Ws_OnMessage;

            ws.Connect();
            cmds = new Dictionary<long, JObject>();
        }

        void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            if (e.IsText)
            {
                var json = JObject.Parse(e.Data);

                if (json["id"] != null)
                    cmds[long.Parse(json["id"].ToString())] = json;
                //else
                //    Console.WriteLine("Unhadle message: " + json);
            }
        }

        void Ws_OnOpen(object sender, EventArgs e)
        {
            Console.WriteLine("Opening Connection");
        }

        void Ws_OnError(object sender, WebSocketSharp.ErrorEventArgs e)
        {
            Console.WriteLine("Error: " + e.Message);
        }

        void Ws_OnClose(object sender, CloseEventArgs e)
        {
            Console.WriteLine("Closing Connection");
        }

        public void CloseConnection()
        {
            ws.Close();
        }

        public async Task<JObject> Command(string command, params KeyValuePair<string, string>[] args)
        {
            return await Task.Run<JObject>(() =>
            {
                var cmd = StringCommand(command, args);
                ws.Send(cmd.Item2);

                while (cmds[cmd.Item1] == null)
                    System.Threading.Thread.Sleep(this.TimeCheckResponse.Milliseconds);

                return cmds[cmd.Item1];
            });
        }
    }
}
