using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.BrowserDomain
{
    public partial class BrowserDomain : Domain
    {
        /// <summary>
        /// {1}
        /// <see cref="{2}"/>
        /// </summary>
        /// <param name="rawDriver"></param>
        internal BrowserDomain(RawDriver rawDriver) : base(rawDriver, "Browser") { }
    }
}
