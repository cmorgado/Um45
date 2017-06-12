using Xamarin.Forms;

namespace Um45.Controls.Behaviors
{
    public class MinLengthBehavior : Behavior<Entry>
    {
     
        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += OnTextChanged;

            base.OnAttachedTo(bindable);
        }

        void OnTextChanged(object sender, TextChangedEventArgs args)
        {
            if (args.NewTextValue == null) return;

            var isValid = args.NewTextValue.Length > 3;

            ((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= OnTextChanged;

            base.OnDetachingFrom(bindable);
        }
    }
}