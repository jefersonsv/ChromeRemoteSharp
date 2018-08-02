# ChromeRemoteSharp

[![License](http://img.shields.io/:license-mit-blue.svg)](http://gep13.mit-license.org) [![NuGet version (ChromeRemoteSharp)](https://img.shields.io/nuget/v/ChromeRemoteSharp.svg?style=flat-square)](https://www.nuget.org/packages/ChromeRemoteSharp/)

Low level implementation of Chrome DevTools Protocol

## 1.1. Table of contents
<!-- TOC -->

- [ChromeRemoteSharp](#chromeremotesharp)
    - [1.1. Table of contents](#11-table-of-contents)
    - [1.2. Domains available](#12-domains-available)
    - [1.3. Sample](#13-sample)

<!-- /TOC -->

## 1.2. Domains available

- Accessibility
- ​Animation
- ​ApplicationCache
- ​Audits
- ​Browser
- ​CacheStorage
- ​Console
- ​CSS
- ​Database
- ​Debugger
- ​DeviceOrientation
- ​DOM
- ​DOMDebugger
- ​DOMSnapshot
- ​DOMStorage
- ​Emulation
- ​HeadlessExperimental
- ​HeapProfiler
- ​IndexedDB
- ​Input
- ​Inspector
- ​IO
- ​LayerTree
- ​Log
- ​Memory
- ​Network
- ​Overlay
- ​Page
- ​Performance
- ​Profiler
- ​Runtime
- ​Schema
- ​Security
- ​ServiceWorker
- ​Storage
- ​SystemInfo
- ​Target
- ​Tethering
- ​Tracing

## 1.3. Sample

```c#
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
```