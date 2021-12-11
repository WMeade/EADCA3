#pragma checksum "C:\Users\Wesley\source\repos\CA3A\CA3A\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6d6c14af0c51a09d8d2ebaf2340cc366a206717"
// <auto-generated/>
#pragma warning disable 1591
namespace CA3A.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Wesley\source\repos\CA3A\CA3A\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wesley\source\repos\CA3A\CA3A\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Wesley\source\repos\CA3A\CA3A\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Wesley\source\repos\CA3A\CA3A\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Wesley\source\repos\CA3A\CA3A\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Wesley\source\repos\CA3A\CA3A\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Wesley\source\repos\CA3A\CA3A\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Wesley\source\repos\CA3A\CA3A\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Wesley\source\repos\CA3A\CA3A\_Imports.razor"
using CA3A;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Wesley\source\repos\CA3A\CA3A\_Imports.razor"
using CA3A.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Wesley\source\repos\CA3A\CA3A\Pages\Index.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid bg-dark h-100 text-white");
            __builder.AddMarkupContent(2, "<nav class=\"navbar navbar-expand-lg navbar-light bg-dark row\"><a class=\"navbar-brand\">Chess Stats</a></nav>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "input-group mb-3 h-100 row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "input-group-prepend");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Wesley\source\repos\CA3A\CA3A\Pages\Index.razor"
                                                                 getstats

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "style", "color:gold;");
            __builder.AddAttribute(11, "type", "button");
            __builder.AddAttribute(12, "id", "button-addon4");
            __builder.AddContent(13, "Search");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "text");
            __builder.AddAttribute(17, "class", "form-control");
            __builder.AddAttribute(18, "placeholder", "Lichess username");
            __builder.AddAttribute(19, "aria-describedby", "button-addon4");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\Wesley\source\repos\CA3A\CA3A\Pages\Index.razor"
                                                              playerSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => playerSearch = __value, playerSearch));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n     <hr class=\"my-4\" style=\"border-top: 1px solid white\">");
#nullable restore
#line 21 "C:\Users\Wesley\source\repos\CA3A\CA3A\Pages\Index.razor"
      if(playerStats != null)
     {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "jumbotron col-10 mx-auto bg-secondary");
            __builder.AddMarkupContent(27, "<h1 class=\"display-4\">Main stats</h1>\r\n                <hr class=\"my-4\" style=\"border-top: 1px solid white\">\r\n                ");
            __builder.OpenElement(28, "table");
            __builder.AddAttribute(29, "class", "table table-dark");
            __builder.AddMarkupContent(30, @"<thead><tr><th scope=""col"">Username</th>
                            <th scope=""col"">Playtime(hrs)</th>
                            <th scope=""col"">Games played</th>
                            <th scope=""col"">Wins</th>
                            <th scope=""col"">Losses</th>
                            <th scope=""col"">Draws</th></tr></thead>
                    ");
            __builder.OpenElement(31, "tbody");
            __builder.OpenElement(32, "tr");
            __builder.OpenElement(33, "td");
#nullable restore
#line 40 "C:\Users\Wesley\source\repos\CA3A\CA3A\Pages\Index.razor"
__builder.AddContent(34, playerStats.username);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                            ");
            __builder.OpenElement(36, "td");
#nullable restore
#line 41 "C:\Users\Wesley\source\repos\CA3A\CA3A\Pages\Index.razor"
__builder.AddContent(37, getHoursPlayed());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                            ");
            __builder.OpenElement(39, "td");
#nullable restore
#line 42 "C:\Users\Wesley\source\repos\CA3A\CA3A\Pages\Index.razor"
__builder.AddContent(40, playerStats.count.all);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                            ");
            __builder.OpenElement(42, "td");
#nullable restore
#line 43 "C:\Users\Wesley\source\repos\CA3A\CA3A\Pages\Index.razor"
__builder.AddContent(43, playerStats.count.win);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                            ");
            __builder.OpenElement(45, "td");
#nullable restore
#line 44 "C:\Users\Wesley\source\repos\CA3A\CA3A\Pages\Index.razor"
__builder.AddContent(46, playerStats.count.loss);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                            ");
            __builder.OpenElement(48, "td");
#nullable restore
#line 45 "C:\Users\Wesley\source\repos\CA3A\CA3A\Pages\Index.razor"
__builder.AddContent(49, playerStats.count.draw);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\Wesley\source\repos\CA3A\CA3A\Pages\Index.razor"
     }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\Wesley\source\repos\CA3A\CA3A\Pages\Index.razor"
       

    public Stats playerStats;
    public String playerSearch;

    public async Task getstats()
    {
        playerStats = await Http.GetFromJsonAsync<Stats>(String.Format("https://lichess.org/api/user/{0}", playerSearch));
    }

    public int getHoursPlayed()
    {
        return playerStats.playTime.total / 60;
    }


    public class Antichess
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
    }

    public class Atomic
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class Blitz
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
    }

    public class KingOfTheHill
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class Crazyhouse
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
    }

    public class Bullet
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class Correspondence
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class Horde
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class Puzzle
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
    }

    public class Classical
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
        public bool prov { get; set; }
    }

    public class Rapid
    {
        public int games { get; set; }
        public int rating { get; set; }
        public int rd { get; set; }
        public int prog { get; set; }
    }

    public class Storm
    {
        public int runs { get; set; }
        public int score { get; set; }
    }

    public class Streak
    {
        public int runs { get; set; }
        public int score { get; set; }
    }

    public class Perfs
    {
        public Antichess antichess { get; set; }
        public Atomic atomic { get; set; }
        public Blitz blitz { get; set; }
        public KingOfTheHill kingOfTheHill { get; set; }
        public Crazyhouse crazyhouse { get; set; }
        public Bullet bullet { get; set; }
        public Correspondence correspondence { get; set; }
        public Horde horde { get; set; }
        public Puzzle puzzle { get; set; }
        public Classical classical { get; set; }
        public Rapid rapid { get; set; }
        public Storm storm { get; set; }
        public Streak streak { get; set; }
    }

    public class PlayTime
    {
        public int total { get; set; }
        public int tv { get; set; }
    }

    public class Count
    {
        public int all { get; set; }
        public int rated { get; set; }
        public int ai { get; set; }
        public int draw { get; set; }
        public int drawH { get; set; }
        public int loss { get; set; }
        public int lossH { get; set; }
        public int win { get; set; }
        public int winH { get; set; }
        public int bookmark { get; set; }
        public int playing { get; set; }
        public int import { get; set; }
        public int me { get; set; }
    }

    public class Stats
    {
        public string id { get; set; }
        public string username { get; set; }
        public Perfs perfs { get; set; }
        public long createdAt { get; set; }
        public bool online { get; set; }
        public long seenAt { get; set; }
        public PlayTime playTime { get; set; }
        public string url { get; set; }
        public Count count { get; set; }
        public bool followable { get; set; }
        public bool following { get; set; }
        public bool blocking { get; set; }
        public bool followsYou { get; set; }
    }






#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
