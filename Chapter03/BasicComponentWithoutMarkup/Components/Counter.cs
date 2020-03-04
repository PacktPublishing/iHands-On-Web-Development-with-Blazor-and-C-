namespace BasicComponentWithoutMarkup.Components
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
}