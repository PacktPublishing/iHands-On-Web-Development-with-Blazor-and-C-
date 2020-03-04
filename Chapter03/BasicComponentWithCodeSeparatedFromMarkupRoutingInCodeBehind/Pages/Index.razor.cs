// Don't forget to specify the namespace.
namespace BasicComponentWithCodeSeparatedFromMarkupRoutingInCodeBehind
{
    using Microsoft.AspNetCore.Components;

    // The class has to have a different name from the markup one, a convention is to suffix it with "Base".
    // The class has to implement the class "ComponentBase".
    [Route("/")]
    public class IndexBase : ComponentBase
    {
        // Properties have to be protected or public to be visible in the component class.
        protected const string Title = "Price calculator";

        protected const string Message = "This is a micro sample about separate the code behind from the UI markup.";

        protected int NumberOfClicks = 0;

        protected void IncrementNumberOfClicks()
        {
            this.NumberOfClicks += 1;
        }
    }
}