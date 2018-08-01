using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.LayerTreeDomain
{
    public partial class LayerTreeDomain : BaseDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/LayerTree"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal LayerTreeDomain(RawDriver rawDriver) : base(rawDriver, "LayerTree") { }
    }
}
