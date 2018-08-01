using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp
{
    public abstract class BaseDomain
    {
        readonly string prefix;
        readonly RawDriver driver;

        protected BaseDomain(RawDriver _driver, string _prefix)
        {
            this.prefix = _prefix;
            this.driver = _driver;
        }

        protected async Task<JObject> CommandAsync(string command, params KeyValuePair<string, object>[] args)
        {
            return await driver.Command($"{prefix}.{command}", args);
        }
    }
}
