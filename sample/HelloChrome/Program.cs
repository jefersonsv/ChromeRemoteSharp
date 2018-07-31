using System;
using System.Threading;
using System.Threading.Tasks;
using ChromeRemoteSharp;

namespace HelloChrome
{
    class Program
    {
        static WebDriver driver = null;

        static void Main(string[] args)
        {
            var url = Helper.FirstWebSocketDebuggerUrlAsync().Result;
            driver = new WebDriver(url);

            Run();

            System.Threading.Thread.Sleep(Timeout.Infinite);
            driver.CloseConnection();
        }

        static async Task Run()
        {
            // navigate
            var naviJson = await driver.Page.NavigateAsync(new Uri("https://www.globo.com"));
            var frameId = naviJson["result"]["frameId"].ToString();
            
            // screenshot
            var screenShotJson = await driver.Page.CaptureScreenshotAsync();

            // get version
            Console.WriteLine(await driver.Browser.GetVersionAsync());

            // get browser command line
            Console.WriteLine(await driver.Browser.GetBrowserCommandLineAsync());

            // page cookies
            Console.WriteLine(await driver.Page.GetCookiesAsync());

            // get document
            var docJson = await driver.Dom.GetDocumentAsync();
            var nodeId = docJson["result"]["root"]["nodeId"].ToString();

            // get html
            var htmlJson = await driver.Dom.GetOuterHtmlAsync(int.Parse(nodeId));
            var html = htmlJson["result"]["outerHTML"].ToString();
        }
    }
}
