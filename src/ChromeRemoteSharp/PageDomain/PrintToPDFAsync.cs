using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ChromeRemoteSharp.PageDomain
{
    public partial class PageDomain
    {
        /// <summary>
        /// Print page as PDF.
        /// <see cref="https://chromedevtools.github.io/devtools-protocol/tot/Page#method-printToPDF"/>
        /// </summary>
        /// <param name="landscape">Paper orientation. Defaults to false.</param>
        /// <param name="displayHeaderFooter">Display header and footer. Defaults to false.</param>
        /// <param name="printBackground">Print background graphics. Defaults to false.</param>
        /// <param name="scale">Scale of the webpage rendering. Defaults to 1.</param>
        /// <param name="paperWidth">Paper width in inches. Defaults to 8.5 inches.</param>
        /// <param name="paperHeight">Paper height in inches. Defaults to 11 inches.</param>
        /// <param name="marginTop">Top margin in inches. Defaults to 1cm (~0.4 inches).</param>
        /// <param name="marginBottom">Bottom margin in inches. Defaults to 1cm (~0.4 inches).</param>
        /// <param name="marginLeft">Left margin in inches. Defaults to 1cm (~0.4 inches).</param>
        /// <param name="marginRight">Right margin in inches. Defaults to 1cm (~0.4 inches).</param>
        /// <param name="pageRanges">Paper ranges to print, e.g., '1-5, 8, 11-13'. Defaults to the empty string, which means print all pages.</param>
        /// <param name="ignoreInvalidPageRanges">Whether to silently ignore invalid but successfully parsed page ranges, such as '3-2'. Defaults to false.</param>
        /// <param name="headerTemplate">HTML template for the print header. Should be valid HTML markup with following classes used to inject printing values into them: - `date`: formatted print date - `title`: document title - `url`: document location - `pageNumber`: current page number - `totalPages`: total pages in the document  For example, `<span class=title></span>` would generate span containing the title.</param>
        /// <param name="footerTemplate">HTML template for the print footer. Should use the same format as the `headerTemplate`.</param>
        /// <param name="preferCSSPageSize">Whether or not to prefer page size as defined by css. Defaults to false, in which case the content will be scaled to fit the paper size.</param>
        /// <returns></returns>
        public async Task<JObject> PrintToPDFAsync(bool? landscape = null, bool? displayHeaderFooter = null, bool? printBackground = null, int? scale = null, int? paperWidth = null, int? paperHeight = null, int? marginTop = null, int? marginBottom = null, int? marginLeft = null, int? marginRight = null, string pageRanges = null, bool? ignoreInvalidPageRanges = null, string headerTemplate = null, string footerTemplate = null, bool? preferCSSPageSize = null)
        {
            return await CommandAsync("printToPDF", 
                 new KeyValuePair<string, object>("landscape", landscape), 
                 new KeyValuePair<string, object>("displayHeaderFooter", displayHeaderFooter), 
                 new KeyValuePair<string, object>("printBackground", printBackground), 
                 new KeyValuePair<string, object>("scale", scale), 
                 new KeyValuePair<string, object>("paperWidth", paperWidth), 
                 new KeyValuePair<string, object>("paperHeight", paperHeight), 
                 new KeyValuePair<string, object>("marginTop", marginTop), 
                 new KeyValuePair<string, object>("marginBottom", marginBottom), 
                 new KeyValuePair<string, object>("marginLeft", marginLeft), 
                 new KeyValuePair<string, object>("marginRight", marginRight), 
                 new KeyValuePair<string, object>("pageRanges", pageRanges), 
                 new KeyValuePair<string, object>("ignoreInvalidPageRanges", ignoreInvalidPageRanges), 
                 new KeyValuePair<string, object>("headerTemplate", headerTemplate), 
                 new KeyValuePair<string, object>("footerTemplate", footerTemplate), 
                 new KeyValuePair<string, object>("preferCSSPageSize", preferCSSPageSize)
                 );
        }
    }
}
