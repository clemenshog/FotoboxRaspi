#pragma checksum "C:\Fotobox\UIFotobox\Client\Pages\MainScreen.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d710bf042666f786ddbc7211c1a64d3440ee69df"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1> New Picture</h1>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "<img class=\"mainImage\" src=\"/images/0.jpg\">\r\n\r\n    ");
            __builder.OpenElement(3, "footer");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "print-button");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Fotobox\UIFotobox\Client\Pages\MainScreen.razor"
                                               ()=>SendToPrinter()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "<span class=\"print-icon\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "class", "newImage");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Fotobox\UIFotobox\Client\Pages\MainScreen.razor"
                                           () => NewImage()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(12, "<i class=\'oi oi-camera-slr\'></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Fotobox\UIFotobox\Client\Pages\MainScreen.razor"
       
    // Public Eigenschaft f??r Index verwenden
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
