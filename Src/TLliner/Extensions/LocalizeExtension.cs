using Microsoft.Extensions.Localization;
using TLliner.DependencyInjection;
using TLliner.Resources.Strings;

namespace TLliner.Extensions
{
    [ContentProperty(nameof(Key))]
    internal class LocalizeExtension : IMarkupExtension
    {
        public LocalizeExtension()
        {
            localizer = ServiceHelper.GetService<IStringLocalizer<AppStrings>>();
        }

        public string Key { get; set; } = string.Empty;

        private IStringLocalizer<AppStrings> localizer { get; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            string localizedText = localizer[Key];
            return localizedText;
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider) => ProvideValue(serviceProvider);
    }
}