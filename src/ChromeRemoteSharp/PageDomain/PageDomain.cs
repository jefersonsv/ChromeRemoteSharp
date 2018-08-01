using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.PageDomain
{
    public partial class PageDomain : BaseDomain
    {
        internal PageDomain(RawDriver driver) : base(driver, "Page") { }
    }
}
