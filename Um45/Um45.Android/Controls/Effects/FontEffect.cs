using Um45.Droid.Controls.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("Um45")]
[assembly: ExportEffect(typeof(FontEffect), "FontEffect")]
namespace Um45.Droid.Controls.Effects
{

        public class FontEffect : PlatformEffect
        {
            protected override void OnAttached()
            {
                //var textView = (UITextField)ResourceBundle.Control;

                //textView.Font = Font.FromName("Avenir-LightOblique", 24);
            }

            protected override void OnDetached()
            {
            }
        }
}