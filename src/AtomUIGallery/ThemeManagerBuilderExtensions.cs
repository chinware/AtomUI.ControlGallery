using AtomUI.Theme;
using AtomUI.Theme.Language;

namespace AtomUIGallery;

public static class ThemeManagerBuilderExtensions
{
    public static IThemeManagerBuilder UseGalleryControls(this IThemeManagerBuilder themeManagerBuilder)
    {
        themeManagerBuilder.AppBuilder.AfterSetup(_ =>
        {
            var languageProviders = LanguageProviderPool.GetLanguageProviders();
            foreach (var languageProvider in languageProviders)
            {
                themeManagerBuilder.AddLanguageProviders(languageProvider);
            }
        });

        return themeManagerBuilder;
    }
}