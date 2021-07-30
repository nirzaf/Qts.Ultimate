using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Qts.Ultimate.Localization
{
    public static class UltimateLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(UltimateConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(UltimateLocalizationConfigurer).GetAssembly(),
                        "Qts.Ultimate.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
