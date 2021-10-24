#pragma checksum "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\PublishedQuestions.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c3801e05f828baeabbedb3f9dfad7d11414e01b"
// <auto-generated/>
#pragma warning disable 1591
namespace DotNetTeacherBot.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\_Imports.razor"
using DotNetTeacherBot.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\_Imports.razor"
using DotNetTeacherBot.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\_Imports.razor"
using DotNetTeacherBot;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/questions/published")]
    public partial class PublishedQuestions : OwningComponentBase<IQuestionRepo>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, @"<thead><tr><th>
                    ID
                </th>
                <th>
                    Name
                </th>
                <th>
                    Question
                </th>
                <th>
                    Answer
                </th></tr></thead>
        ");
            __builder.OpenElement(3, "tbody");
#nullable restore
#line 23 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\PublishedQuestions.razor"
             if(QuestionData?.Count() > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\PublishedQuestions.razor"
                 foreach(Question q in QuestionData)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "tr");
            __builder.OpenElement(5, "td");
            __builder.AddContent(6, 
#nullable restore
#line 28 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\PublishedQuestions.razor"
                     q.ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n                ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 29 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\PublishedQuestions.razor"
                     q.ShortQuestion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 30 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\PublishedQuestions.razor"
                     q.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 31 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\PublishedQuestions.razor"
                     q.Answer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(18);
            __builder.AddAttribute(19, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(20, "href", 
#nullable restore
#line 33 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\PublishedQuestions.razor"
                                                                GetPublishUrl(q.ID)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(22, "Unpublish");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
            __builder.AddAttribute(25, "class", "btn btn-warning btn-sm");
            __builder.AddAttribute(26, "href", 
#nullable restore
#line 34 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\PublishedQuestions.razor"
                                                                   GetEditUrl(q.ID)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(28, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\PublishedQuestions.razor"
                                                                      e => DeleteQuestion(q)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\PublishedQuestions.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\PublishedQuestions.razor"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "<tr><td colspan=\"5\" class=\"text-center\">No Products</td></tr>");
#nullable restore
#line 45 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\PublishedQuestions.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(36);
            __builder.AddAttribute(37, "class", "btn btn-primary");
            __builder.AddAttribute(38, "href", "admin/question/create");
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(40, "Create");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\Viktor\repos\DotNetTeacherBot\Pages\Admin\PublishedQuestions.razor"
       
    public IQuestionRepo Repository => Service;
    public IEnumerable<Question> QuestionData { get; set; }
    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }
    public async Task UpdateData()
    {
        QuestionData = await Repository.PublishedQuestions.ToListAsync();
    }
    public async Task DeleteQuestion(Question q)
    {
        Repository.DeleteQuestion(q);
        await UpdateData();
    }
    public string GetPublishUrl(long id) => $"/admin/questions/publish/{id}";
    public string GetEditUrl(long id) => $"/admin/questions/edit/{id}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
