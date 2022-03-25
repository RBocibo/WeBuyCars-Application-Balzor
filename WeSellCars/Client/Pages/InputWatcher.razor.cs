using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace WeSellCars.Client.Pages
{
    public class InputWatcher : ComponentBase
    {
        private EditContext editContext = default!;

        [Parameter]
        public EventCallback<string> FieldChanged { get; set; }

        [CascadingParameter]

        public EditContext EditContext
        {
            get
            {
                return editContext;
            }
            set
            {
                editContext = value;

                EditContext.OnFieldChanged += async (sender, args) =>
                {
                    await FieldChanged.InvokeAsync(args.FieldIdentifier.FieldName);
                };
            }
        }
   
        public bool Validate() => EditContext?.Validate() ?? false; 

    }
}
