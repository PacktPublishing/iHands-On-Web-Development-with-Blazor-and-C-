namespace CounterComponentWithoutMarkup.Components
{
    using Microsoft.AspNetCore.Components;
    using Microsoft.AspNetCore.Components.Rendering;

    public class Counter : ComponentBase
    {
        private const string title = "This is a counter";

        protected int CurrentNumber {get;set;}

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(1, "h1");
            builder.AddContent(2, title);
            builder.CloseElement();

            builder.OpenElement(3, "span");
            builder.AddAttribute(4, "class", "counter-result");
            builder.AddContent(5, this.CurrentNumber);
            builder.CloseElement();

            builder.OpenElement(6, "button");
            builder.AddAttribute(2, "onclick" , Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, IncrementCurrentNumber ));
            builder.AddContent(8, "Increment");
            builder.CloseElement();
        }

        protected void IncrementCurrentNumber()
        {
            this.CurrentNumber += 1;
        }
    }
	
	// If you wonder why I hardcode sequence numbers, read this gist from our guru, I named Steve Sanderson: https://gist.github.com/SteveSandersonMS/ec232992c2446ab9a0059dd0fbc5d0c3
}