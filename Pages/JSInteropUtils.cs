using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignatureGenerator.Pages
{
    public class JSInteropUtils
    {
        
        public async static Task<string> SaveDivAsImage(IJSRuntime jSRuntime,string divName)
        {
            string data = await jSRuntime.InvokeAsync<string>("SaveDivAsImage", new{ div = divName});
            return data;
        }
    }
}
