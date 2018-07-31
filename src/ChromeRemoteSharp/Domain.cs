using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp
{
    public abstract class Domain
    {
        readonly string prefix;
        readonly WebDriver driver;

        protected Domain(WebDriver _driver, string _prefix)
        {
            this.prefix = _prefix;
            this.driver = _driver;
        }

        protected async Task<JObject> CommandAsync(string command, params KeyValuePair<string, string>[] args)
        {
            return await driver.Command($"{prefix}.{command}", args);
        }
    }
}
