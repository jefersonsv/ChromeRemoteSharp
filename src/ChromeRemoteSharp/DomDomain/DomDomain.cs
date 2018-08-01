using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.DomDomain
{
    public partial class DomDomain : Domain
    {
        internal DomDomain(RawDriver driver) : base(driver, "DOM") { }
    }
}
