using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.BrowserDomain
{
    public partial class BrowserDomain : Domain
    {
        public BrowserDomain(WebDriver driver) : base(driver, "Browser") { }
    }
}
