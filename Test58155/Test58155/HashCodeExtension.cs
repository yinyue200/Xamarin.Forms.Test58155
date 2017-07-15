using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test58155
{
    [ContentProperty("Text")]
    class HashCodeExtension : IMarkupExtension<string>
    {
        public string Text { get; set; }
        public string ProvideValue(IServiceProvider serviceProvider)
        {
            return Text.GetHashCode().ToString();
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return Text.GetHashCode().ToString();
        }
    }
}
