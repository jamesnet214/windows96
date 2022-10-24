using Avalonia.Web.Blazor;

namespace Windows96.Web
{
    public partial class App
    {
        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            WebAppBuilder.Configure<Windows96.App>()
                .SetupWithSingleViewLifetime();
        }
    }
}