using AtomUIGallery.ShowCases.ViewModels;
using AtomUIGallery.ShowCases.Views;
using ReactiveUI;
using Splat;

namespace AtomUIGallery.ShowCases;

internal static class ShowCaseRegister
{
    public static void Register()
    {
        Locator.CurrentMutable.Register(() => new PaletteShowCase(), typeof(IViewFor<PaletteShowCaseViewModel>));
    }
}