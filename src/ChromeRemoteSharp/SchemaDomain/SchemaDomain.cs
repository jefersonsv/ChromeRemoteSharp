using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.SchemaDomain
{
    public partial class SchemaDomain : BaseDomain
    {
        /// <summary>
        /// This domain is deprecated.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Schema"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal SchemaDomain(RawDriver rawDriver) : base(rawDriver, "Schema") { }
    }
}
