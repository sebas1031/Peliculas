#pragma checksum "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Actors\ShowActor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c65c70a822a54eb6b6bfc82abff05196f93d2f5f"
// <auto-generated/>
#pragma warning disable 1591
namespace MoviesProy.Client.Pages.Actors
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
#nullable restore
#line 2 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Actors\ShowActor.razor"
using MoviesProy.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/actors")]
    public partial class ShowActor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"form-group\"><a href=\"actors/create\" class=\"btn btn-info\">Crear Actor</a>\r\n    <a href=\"/actors/edit/{ActorId:int}\" class=\"btn btn-dark\">Editar Actor</a></div>\r\n");
            __builder.OpenComponent<MoviesProy.Client.Pages.Components.CardActorComponent>(1);
            __builder.AddAttribute(2, "Actors", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<MoviesProy.Shared.Entity.Actor>>(
#nullable restore
#line 9 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Actors\ShowActor.razor"
                            Actors

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\asus\Downloads\MoviesProy\Client\Pages\Actors\ShowActor.razor"
       
    private List<Actor> Actors;
    protected override void OnInitialized()
    {
        Actors = actor.GetActor();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicesActor actor { get; set; }
    }
}
#pragma warning restore 1591
