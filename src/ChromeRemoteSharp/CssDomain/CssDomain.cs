using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.CssDomain
{
    public partial class CssDomain : BaseDomain
    {
        /// <summary>
        /// This domain exposes CSS read/write operations. All CSS objects (stylesheets, rules, and styles) have an associated `id` used in subsequent operations on the related object. Each object type has a specific `id` structure, and those are not interchangeable between objects of different kinds. CSS objects can be loaded using the `get*ForNode()` calls (which accept a DOM node id). A client can also keep track of stylesheets via the `styleSheetAdded`/`styleSheetRemoved` events and subsequently load the required stylesheet contents using the `getStyleSheet[Text]()` methods.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Css"/>
        /// </summary>
        /// <param name="rawDriver">Drive to invoke web sockets</param>
        internal CssDomain(RawDriver rawDriver) : base(rawDriver, "Css") { }
    }
}
