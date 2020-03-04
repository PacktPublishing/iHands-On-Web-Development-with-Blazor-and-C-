using Microsoft.AspNetCore.Components;

namespace BasicComponentWithCodeSeparatedFromMarkupByPartialClass.Components
{
    public partial class Counter 
    {
        protected const string Title = "This is a counter without any markup class.";

        protected int CurrentNumber { get;set;}

        [Parameter]
        public int StartCountNumber {get;set;}

        protected override void OnInitialized()
        {
            this.CurrentNumber = this.StartCountNumber;
        }

        public void Increment()
        {
            this.CurrentNumber += 1;
        }

        public void Decrement()
        {
            this.CurrentNumber -= 1;
        }
    }
}