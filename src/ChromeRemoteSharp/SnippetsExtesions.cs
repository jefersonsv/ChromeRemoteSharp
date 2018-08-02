using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChromeRemoteSharp
{
    public static class SnippetsExtesions
    {
        public static async Task ClickAsync(this LowLevelDriver driver, int nodeId)
        {
            var id = Guid.NewGuid().ToString();
            await driver.Dom.SetAttributesAsTextAsync(nodeId, $"id='{id}'");
            await driver.Runtime.EvaluateAsync($"document.getElementById('{id}').click()");
        }

        public static async Task<string> GetSourceCode(this LowLevelDriver driver)
        {
            // get document
            var docJson = await driver.Dom.GetDocumentAsync();
            var nodeId = docJson["root"]["nodeId"].ToObject<int>();

            // get html
            var htmlJson = await driver.Dom.GetOuterHTMLAsync(nodeId);
            return htmlJson["outerHTML"].ToString();
        }
    }
}
