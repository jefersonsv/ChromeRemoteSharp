using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.RuntimeDomain
{
    public partial class RuntimeDomain : BaseDomain
    {
        /// <summary>
        /// Runtime domain exposes JavaScript runtime by means of remote evaluation and mirror objects. Evaluation results are returned as mirror object that expose object type, string representation and unique identifier that can be used for further object reference. Original objects are maintained in memory unless they are either explicitly released or are released along with the other objects in their object group.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Runtime"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal RuntimeDomain(RawDriver rawDriver) : base(rawDriver, "Runtime") { }
    }
}
