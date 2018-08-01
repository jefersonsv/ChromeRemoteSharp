using System;
using System.Collections.Generic;
using System.Text;

namespace ChromeRemoteSharp
{
    public class LowLevelDriver : RawDriver
    {
        public DomDomain.DomDomain Dom { get; }
        public BrowserDomain.BrowserDomain Browser { get; }
        public PageDomain.PageDomain Page { get; }

        public LowLevelDriver(Uri uri) : base(uri)
        {
            this.Dom = new DomDomain.DomDomain(this);
            this.Browser = new BrowserDomain.BrowserDomain(this);
            this.Page = new PageDomain.PageDomain(this);
        }

    }
}
