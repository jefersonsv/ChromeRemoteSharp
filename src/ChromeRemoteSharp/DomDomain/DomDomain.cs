using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.DomDomain
{
    public partial class DomDomain : Domain
    {
        public DomDomain(WebDriver driver) : base(driver, "DOM") { }
    }
}
