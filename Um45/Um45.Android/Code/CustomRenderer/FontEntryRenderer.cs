using Android.Graphics;
using Um45.Droid.Code.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(FontEntryRenderer))]
namespace Um45.Droid.Code.CustomRenderer
{
    public class FontEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                if (Element.FontFamily != null)
                {
                    if (Element.FontFamily.Equals("GothamRegular"))
                    {
                        Element.FontFamily = "GothamMedium";
                    }
                    Control.Typeface = Typeface.CreateFromAsset(Forms.Context.Assets, $"{Element.FontFamily}.ttf");
                }
            }
        }
    }
}