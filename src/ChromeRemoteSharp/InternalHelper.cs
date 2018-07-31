using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp
{
    public partial class WebDriver
    {
        

        (long, string) StringCommand(string method, params KeyValuePair<string, string>[] args)
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
                    param[item.Key] = item.Value;
                }

                obj["params"] = param;
            }

            return (currentId, obj.ToString());
        }
    }
}
