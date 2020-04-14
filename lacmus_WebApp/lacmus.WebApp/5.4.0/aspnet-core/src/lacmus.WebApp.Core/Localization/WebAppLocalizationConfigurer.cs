using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace lacmus.WebApp.Localization
{
    public static class WebAppLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(WebAppConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(WebAppLocalizationConfigurer).GetAssembly(),
                        "lacmus.WebApp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
