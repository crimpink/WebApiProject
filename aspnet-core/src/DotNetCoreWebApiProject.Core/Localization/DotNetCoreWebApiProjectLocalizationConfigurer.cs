using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace DotNetCoreWebApiProject.Localization
{
    public static class DotNetCoreWebApiProjectLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(DotNetCoreWebApiProjectConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(DotNetCoreWebApiProjectLocalizationConfigurer).GetAssembly(),
                        "DotNetCoreWebApiProject.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
