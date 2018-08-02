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
            Helper.KillAllChromeInstances(); // kill all opened instances of google chrome
            Helper.StartChromeDevTools(); // start new chrome browser instance point to http://localhost:9222

            if (!await Helper.CheckWebSocketAsync()) // check if remote debugging url it's available
                Helper.StartChromeHeadless(); // start a headless instance of google chrome
                
            var url = await Helper.FirstWebSocketDebuggerUrlAsync(); // get the first ws remote url
            driver = new LowLevelDriver(url); // instance driver

            // navigate
            await driver.Page.NavigateAsync("https://www.msn.com"); // navigate
            System.Threading.Thread.Sleep(2000);
            
            // screenshot
            var screenShotJson = await driver.Page.CaptureScreenshotAsync(); // capture image and return base64 json image
            Console.WriteLine(screenShotJson);

            // get version
            Console.WriteLine(await driver.Browser.GetVersionAsync()); // get browser version

            // get browser command line
            Console.WriteLine(await driver.Browser.GetBrowserCommandLineAsync()); // get all command lines of headless instance

            // page cookies
            Console.WriteLine(await driver.Page.GetCookiesAsync()); // get all cookies

            // get document
            var docJson = await driver.Dom.GetDocumentAsync(); // get document in raw format devtools protocol
            var nodeId = docJson["root"]["nodeId"].ToObject<int>();

            // get html
            var htmlJson = await driver.Dom.GetOuterHTMLAsync(nodeId); // get source code of page
            var html = htmlJson["outerHTML"].ToString();
            Console.WriteLine(html);
        }
    }
}
