using System;
using System.Threading;
using System.Threading.Tasks;
using ChromeRemoteSharp;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace HelloChrome
{
    class Program
    {
        static LowLevelDriver driver = null;

        static void Main(string[] args)
        {
            Run();

            Console.ReadKey();
            driver.CloseConnection();
        }

        static async Task Run()
        {
            Helper.KillAllChromeInstances();
            Helper.StartChromeDevTools();
            
            if (!await Helper.CheckWebSocketAsync())
                Helper.StartChromeHeadless();
                
            var url = await Helper.FirstWebSocketDebuggerUrlAsync();
            driver = new LowLevelDriver(url);

            // navigate
            await driver.Page.NavigateAsync("https://www.msn.com");
            System.Threading.Thread.Sleep(2000);
            
            // screenshot
            var screenShotJson = await driver.Page.CaptureScreenshotAsync();
            Console.WriteLine(screenShotJson);

            // get version
            Console.WriteLine(await driver.Browser.GetVersionAsync());

            // get browser command line
            Console.WriteLine(await driver.Browser.GetBrowserCommandLineAsync());

            // page cookies
            Console.WriteLine(await driver.Page.GetCookiesAsync());

            // get document
            var docJson = await driver.Dom.GetDocumentAsync();
            var nodeId = docJson["root"]["nodeId"].ToObject<int>();

            // get html
            var htmlJson = await driver.Dom.GetOuterHTMLAsync(nodeId);
            var html = htmlJson["outerHTML"].ToString();
            Console.WriteLine(html);
        }
    }
}
