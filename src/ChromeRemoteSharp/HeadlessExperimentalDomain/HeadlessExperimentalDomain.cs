using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.HeadlessExperimentalDomain
{
    public partial class HeadlessExperimentalDomain : BaseDomain
    {
        /// <summary>
        /// This domain provides experimental commands only supported in headless mode.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/HeadlessExperimental"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal HeadlessExperimentalDomain(RawDriver rawDriver) : base(rawDriver, "HeadlessExperimental") { }
    }
}
