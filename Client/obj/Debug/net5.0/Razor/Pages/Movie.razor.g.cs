#pragma checksum "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Movie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "878ecd67582f5838428267f3301b87908d391839"
// <auto-generated/>
#pragma warning disable 1591
namespace MoviesProy.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\asus\Downloads\MoviesProy\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\Downloads\MoviesProy\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\asus\Downloads\MoviesProy\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\asus\Downloads\MoviesProy\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\asus\Downloads\MoviesProy\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\asus\Downloads\MoviesProy\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\asus\Downloads\MoviesProy\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\asus\Downloads\MoviesProy\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\asus\Downloads\MoviesProy\Client\_Imports.razor"
using MoviesProy.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\asus\Downloads\MoviesProy\Client\_Imports.razor"
using MoviesProy.Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\asus\Downloads\MoviesProy\Client\_Imports.razor"
using MoviesProy.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\asus\Downloads\MoviesProy\Client\_Imports.razor"
using MoviesProy.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\asus\Downloads\MoviesProy\Client\_Imports.razor"
using MoviesProy.Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Movie/{id}")]
    public partial class Movie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Movie.razor"
 if (movie == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<span>Movie is loading...</span>");
#nullable restore
#line 8 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Movie.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<h3>Details Movie:</h3>\r\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-4");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card");
            __builder.AddAttribute(8, "style", "width: 18rem;");
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "class", "card-img-top");
            __builder.AddAttribute(11, "src", 
#nullable restore
#line 15 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Movie.razor"
                                                movie.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "alt", "Card image cap");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card-body");
            __builder.OpenElement(16, "h5");
            __builder.AddAttribute(17, "class", "card-title");
            __builder.AddContent(18, 
#nullable restore
#line 17 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Movie.razor"
                                            movie.FullTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "p");
            __builder.AddAttribute(21, "class", "card-text");
            __builder.AddContent(22, 
#nullable restore
#line 18 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Movie.razor"
                                          movie.Plot

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, ".");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "ul");
            __builder.AddAttribute(26, "class", "list-group list-group-flush");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "list-group-item");
            __builder.AddContent(29, 
#nullable restore
#line 21 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Movie.razor"
                                                 movie.ReleaseDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "li");
            __builder.AddAttribute(32, "class", "list-group-item");
            __builder.AddContent(33, 
#nullable restore
#line 22 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Movie.razor"
                                                 movie.IMDbRating

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "li");
            __builder.AddAttribute(36, "class", "list-group-item");
            __builder.AddContent(37, 
#nullable restore
#line 23 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Movie.razor"
                                                 movie.Directors

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "li");
            __builder.AddAttribute(40, "class", "list-group-item");
            __builder.AddContent(41, 
#nullable restore
#line 24 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Movie.razor"
                                                 movie.Stars

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "li");
            __builder.AddAttribute(44, "class", "list-group-item");
            __builder.AddContent(45, 
#nullable restore
#line 25 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Movie.razor"
                                                 movie.Companies

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "li");
            __builder.AddAttribute(48, "class", "list-group-item");
            __builder.AddContent(49, 
#nullable restore
#line 26 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Movie.razor"
                                                 movie.Directors

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "li");
            __builder.AddAttribute(52, "class", "list-group-item");
            __builder.AddContent(53, 
#nullable restore
#line 27 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Movie.razor"
                                                 movie.Awards

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        \r\n        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "col");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "embed-responsive embed-responsive-1by1");
            __builder.AddAttribute(59, "width", "250");
            __builder.OpenElement(60, "iframe");
            __builder.AddAttribute(61, "class", "embed-responsive-item");
            __builder.AddAttribute(62, "src", 
#nullable restore
#line 35 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Movie.razor"
                                                            movie.Trailer.LinkEmbed

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Movie.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Movie.razor"
       

[Parameter]
public String id { get; set; }

TitleData movie = null;
protected override async Task OnInitializedAsync()
 {
    movie = await TitleDataService.GetMovie(id);
 }  


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TitleDataServiceInterface TitleDataService { get; set; }
    }
}
#pragma warning restore 1591
