#pragma checksum "C:\Users\asus\Downloads\MoviesProy\Client\Pages\ComingSoonMovies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b1e5cb0a96f66284eb7297979d882670006608d"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ComingSoonMovies")]
    public partial class ComingSoonMovies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Coming Soon Movies</h1>");
#nullable restore
#line 8 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\ComingSoonMovies.razor"
 if (movies == null)
 {
     Console.WriteLine("movies esta vacio.....");

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading Movies... </em></p>");
#nullable restore
#line 12 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\ComingSoonMovies.razor"
 }
 else
 {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\ComingSoonMovies.razor"
                 foreach (NewMovieDataDetail movie in moviesdetails)
                             
                 {   

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-deck");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card mb-3");
            __builder.AddAttribute(6, "style", "max-width: 540px;");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row g-0");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-md-4");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "align", "center");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 22 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\ComingSoonMovies.razor"
                                                                   movie.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "class", "img-fluid");
            __builder.AddAttribute(16, "width", "150");
            __builder.AddAttribute(17, "alt", 
#nullable restore
#line 22 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\ComingSoonMovies.razor"
                                                                                                                   movie.FullTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                                   ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-md-8");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card-body");
            __builder.OpenElement(23, "h5");
            __builder.AddAttribute(24, "class", "card-title");
            __builder.OpenElement(25, "b");
            __builder.AddContent(26, 
#nullable restore
#line 26 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\ComingSoonMovies.razor"
                                                                   movie.FullTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                                        ");
            __builder.OpenElement(28, "p");
            __builder.AddAttribute(29, "class", "card-text");
            __builder.AddMarkupContent(30, "<b>Genres: </b> ");
            __builder.AddContent(31, 
#nullable restore
#line 27 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\ComingSoonMovies.razor"
                                                                              movie.Genres

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                                        ");
            __builder.OpenElement(33, "p");
            __builder.AddAttribute(34, "class", "card-text");
            __builder.AddMarkupContent(35, "<b>Director: </b>");
            __builder.AddContent(36, 
#nullable restore
#line 28 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\ComingSoonMovies.razor"
                                                                               movie.Directors

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                                        ");
            __builder.OpenElement(38, "p");
            __builder.AddAttribute(39, "class", "card-text");
            __builder.AddMarkupContent(40, "<b>Cast: </b>");
            __builder.AddContent(41, 
#nullable restore
#line 29 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\ComingSoonMovies.razor"
                                                                           movie.Stars

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                                        ");
            __builder.OpenElement(43, "p");
            __builder.AddAttribute(44, "class", "card-text");
            __builder.AddMarkupContent(45, "<b>Release Date: </b> ");
            __builder.AddContent(46, 
#nullable restore
#line 30 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\ComingSoonMovies.razor"
                                                                                    movie.ReleaseState

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                                        ");
            __builder.OpenElement(48, "p");
            __builder.AddAttribute(49, "class", "card-text");
            __builder.AddMarkupContent(50, "<b>Synopsis: </b> ");
            __builder.AddContent(51, 
#nullable restore
#line 31 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\ComingSoonMovies.razor"
                                                                                movie.Plot

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                                        ");
            __builder.AddMarkupContent(53, "<div align=\"center\"><img src=\"/images/coming-soon red.jpg\" class=\"img-fluid\" width=\"150\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\ComingSoonMovies.razor"
                                
                                    
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\ComingSoonMovies.razor"
                 
 }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\ComingSoonMovies.razor"
      
 
 NewMovieData movies = new NewMovieData();
 List<NewMovieDataDetail> moviesdetails = new List<NewMovieDataDetail>();
 protected override async Task OnInitializedAsync()
 {
    movies = await ComingSoonService.GetAllMovies(); 
    moviesdetails = movies.Items;
    if (movies == null){
        Console.WriteLine("esta vacio.....");
    }
    else{
        Console.WriteLine("Tiene: ");
        Console.WriteLine(moviesdetails.Count);
    }
   
 }    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ComingSoonServiceInterface ComingSoonService { get; set; }
    }
}
#pragma warning restore 1591
