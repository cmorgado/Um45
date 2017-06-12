using System;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace Um45.Controls.Behaviors
{
    public class EmailValidatorBehavior : Behavior<Entry>
    {
        const string EmailRegex = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += OnTextChanged;

            base.OnAttachedTo(bindable);
        }

        void OnTextChanged(object sender, TextChangedEventArgs args)
        {
            if (args.NewTextValue == null) return;

            var isValid = Regex.IsMatch(args.NewTextValue, EmailRegex, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));

            ((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= OnTextChanged;

            base.OnDetachingFrom(bindable);
        }
    }
}