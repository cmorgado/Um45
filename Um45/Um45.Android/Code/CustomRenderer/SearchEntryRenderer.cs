using Android.Content.Res;
using Android.Support.V4.View;
using Um45.Controls.CustomRenderer;
using Um45.Droid.Code.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(SearchEntry), typeof(SearchEntryRenderer))]
namespace Um45.Droid.Code.CustomRenderer
{
    public class SearchEntryRenderer : FontEntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                ViewCompat.SetBackgroundTintList(Control, ColorStateList.ValueOf(Color.Transparent.ToAndroid()));
            }
        }
    }
}