using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.AnimationDomain
{
    public partial class AnimationDomain : Domain
    {
        /// <summary>
        /// 
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Animation"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal AnimationDomain(RawDriver rawDriver) : base(rawDriver, "Animation") { }
    }
}
