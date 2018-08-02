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
    public class RawDriver
    {
        WebSocket ws;
        long id;
        readonly Dictionary<long, JObject> cmds;

        public TimeSpan TimeCheckResponse { get; set; } = new TimeSpan(0, 0, 0, 0, 100);

        public RawDriver(Uri url)
        {
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
                {
                    if (json["result"] != null)
                        cmds[long.Parse(json["id"].ToString())] = JObject.FromObject(json["result"]);
                    else
                        cmds[long.Parse(json["id"].ToString())] = json;
                }
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

        public async Task<JObject> Command(string command, params KeyValuePair<string, object>[] args)
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

        (long, string) StringCommand(string method, params KeyValuePair<string, object>[] args)
        {
            var currentId = ++id;
            cmds.Add(currentId, null);

            JObject obj = new JObject();
            obj["method"] = method;
            obj["id"] = currentId;

            if (args != null && args.Any())
            {
                JObject param = new JObject();
                foreach (var item in args)
                {
                    if (item.Value != null)
                        param[item.Key] = JToken.FromObject(item.Value);
                }

                if (param.Count > 0)
                    obj["params"] = param;
            }

            return (currentId, obj.ToString());
        }
    }
}
