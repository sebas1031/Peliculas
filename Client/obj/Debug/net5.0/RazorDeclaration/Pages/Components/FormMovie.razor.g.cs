// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MoviesProy.Client.Pages.Components
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
#nullable restore
#line 1 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Components\FormMovie.razor"
using MoviesProy.Client.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Components\FormMovie.razor"
using MoviesProy.Client.Model;

#line default
#line hidden
#nullable disable
    public partial class FormMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Components\FormMovie.razor"
       
    [Parameter] public Movie Movie { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    [Parameter] public List<Category> CategoriasSeleccionadas { get; set; } = new List<Category>();
    [Parameter] public List<Category> CategoriasNoSeleccionadas { get; set; } = new List<Category>();

    private string posterTemporal;
    private List<SelectorMultipleModel> NoSeleccionados { get; set; } = new List<SelectorMultipleModel>();

    private List<SelectorMultipleModel> Seleccionados { get; set; } = new List<SelectorMultipleModel>();



    private void ImageSelected(string imageB64)
    {
        Movie.image = imageB64;
    }


    protected override void OnInitialized()
    {
        Seleccionados = CategoriasSeleccionadas.Select(x => new SelectorMultipleModel(x.Id.ToString(), x.Name)).ToList();
        NoSeleccionados = CategoriasNoSeleccionadas.Select(x => new SelectorMultipleModel(x.Id.ToString(), x.Name)).ToList();
        if (!string.IsNullOrWhiteSpace(Movie.image))
        {
            posterTemporal = Movie.image;
            Movie.image = null;
        }

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
