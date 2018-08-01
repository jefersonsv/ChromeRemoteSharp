using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.InputDomain
{
    public partial class InputDomain : BaseDomain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Input"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal InputDomain(RawDriver rawDriver) : base(rawDriver, "Input") { }
    }
}
