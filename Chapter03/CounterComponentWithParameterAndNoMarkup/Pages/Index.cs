namespace CounterComponentWithoutMarkup
{
    using System;
    using CounterComponentWithParameterAndNoMarkup.Components;
    using Microsoft.AspNetCore.Components;
    using Microsoft.AspNetCore.Components.Rendering;

    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : ComponentBase
    {
        private const string title = "Welcome to a Blazor website without any '.razor' file.";

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            // If you wonder why I hardcode sequence numbers, read this gist from our guru, I named Steve Sanderson: https://gist.github.com/SteveSandersonMS/ec232992c2446ab9a0059dd0fbc5d0c3
            builder.OpenElement(1, "h1");
            builder.AddContent(2, title);
            builder.CloseElement();

            builder.OpenComponent(3, typeof(Counter));
            builder.AddAttribute(4, "StartNumber", this.GetRandomNumber());
            builder.CloseComponent();
        }

        private int GetRandomNumber() =>
            new Random().Next(0, 500);
    }
}