using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.DomDomain
{
    public partial class DomDomain : BaseDomain
    {
        /// <summary>
        /// This domain exposes DOM read/write operations. Each DOM Node is represented with its mirror object that has an `id`. This `id` can be used to get additional information on the Node, resolve it into the JavaScript object wrapper, etc. It is important that client receives DOM events only for the nodes that are known to the client. Backend keeps track of the nodes that were sent to the client and never sends the same node twice. It is client's responsibility to collect information about the nodes that were sent to the client.<p>Note that `iframe` owner elements will return corresponding document elements as their child nodes.</p>
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Dom"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal DomDomain(RawDriver rawDriver) : base(rawDriver, "DOM") { }
    }
}
