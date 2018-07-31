using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp.PageDomain
{
    public partial class PageDomain : Domain
    {
        public PageDomain(WebDriver driver) : base(driver, "Page") { }
    }
}
