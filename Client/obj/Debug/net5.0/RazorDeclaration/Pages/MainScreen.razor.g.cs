// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace UIFotobox.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Fotobox\UIFotobox\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Fotobox\UIFotobox\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Fotobox\UIFotobox\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Fotobox\UIFotobox\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Fotobox\UIFotobox\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Fotobox\UIFotobox\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Fotobox\UIFotobox\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Fotobox\UIFotobox\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Fotobox\UIFotobox\Client\_Imports.razor"
using UIFotobox.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Fotobox\UIFotobox\Client\_Imports.razor"
using UIFotobox.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Fotobox\UIFotobox\Client\Pages\MainScreen.razor"
using UIFotobox.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Fotobox\UIFotobox\Client\Pages\MainScreen.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Fotobox\UIFotobox\Client\Pages\MainScreen.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Fotobox\UIFotobox\Client\Pages\MainScreen.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/mainScreen")]
    public partial class MainScreen : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Fotobox\UIFotobox\Client\Pages\MainScreen.razor"
       
    // Public Eigenschaft für Index verwenden
    int index = 0;


    
    protected override async Task OnInitializedAsync()
    {

        for (int i = 0; i < 10; i++)
        {
            string path = "/images/" + i + ".jpg";

            try
            {
                byte[] file = await client.GetByteArrayAsync(path);
               
                index++;
            }
            catch
            {
                break;
            }

        }

    }

    public void NewImage()
    {

        // Run Python Code
        string imgPath = "https://localhost:44381/images/" + index + ".jpg";
        string pyPath = @"\Fotobox\Picture.py";
        string path = @"C:\Users\xelia\AppData\Local\Programs\Python\Python38\python.exe";
       
    }



    public void SendToPrinter()
    {
        // Send Image to Printer
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
