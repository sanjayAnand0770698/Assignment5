#pragma checksum "C:\Users\skpatel\BlazorApp\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8d19a98ea5e4f465afd2f3f79f6079c08c03101"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\skpatel\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\skpatel\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\skpatel\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\skpatel\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\skpatel\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\skpatel\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\skpatel\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\skpatel\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\skpatel\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\skpatel\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\skpatel\BlazorApp\Pages\FetchData.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CharacterList")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "placeholder", "Enter your name");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\skpatel\BlazorApp\Pages\FetchData.razor"
              Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Name = __value, Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n<br>\r\n");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "number");
            __builder.AddAttribute(9, "placeholder", "Enter your age");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\skpatel\BlazorApp\Pages\FetchData.razor"
              Age

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Age = __value, Age, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n<br>\r\n");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "placeholder", "Enter your prefession");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\skpatel\BlazorApp\Pages\FetchData.razor"
              Profession

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Profession = __value, Profession));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n<br>\r\nIs fictional : \r\n");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "checkbox");
            __builder.AddAttribute(20, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\skpatel\BlazorApp\Pages\FetchData.razor"
              IsFictional

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => IsFictional = __value, IsFictional));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n<br>\r\n");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "btn btn-success");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\skpatel\BlazorApp\Pages\FetchData.razor"
                                          UpdateTable

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Add Character");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "    \r\n<br>\r\n\r\n\r\n    ");
            __builder.OpenElement(28, "table");
            __builder.AddAttribute(29, "class", "table");
            __builder.AddMarkupContent(30, "<thead><tr><th>Name</th>\r\n                <th>Age</th>\r\n                <th>Profession</th>\r\n                <th>Is Fictonal</th></tr></thead>\r\n        ");
            __builder.OpenElement(31, "tbody");
#nullable restore
#line 32 "C:\Users\skpatel\BlazorApp\Pages\FetchData.razor"
             foreach (var character in characters)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "tr");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 35 "C:\Users\skpatel\BlazorApp\Pages\FetchData.razor"
                         character.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 36 "C:\Users\skpatel\BlazorApp\Pages\FetchData.razor"
                         character.age.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 37 "C:\Users\skpatel\BlazorApp\Pages\FetchData.razor"
                         character.profession

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 38 "C:\Users\skpatel\BlazorApp\Pages\FetchData.razor"
                         character.isFictional.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\skpatel\BlazorApp\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\skpatel\BlazorApp\Pages\FetchData.razor"
         
    private string Name { get; set; }
    private string Age { get; set; }
    private string Profession { get; set; }
    private string IsFictional { get; set; }
    private List<BlazorApp.Data.Character> characters = new List<BlazorApp.Data.Character>();
    
    private void UpdateTable()
    {
        Character c = new Character();
        c.name = Name;
        c.age = int.Parse(Age);
        c.profession = Profession;
        c.isFictional = bool.Parse(IsFictional);        
        characters.Add(c);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
