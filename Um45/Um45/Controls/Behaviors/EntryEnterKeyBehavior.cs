using Xamarin.Forms;

namespace Um45.Controls.Behaviors
{
    public class EntryEnterKeyBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.Completed += Bindable_Completed;
            base.OnAttachedTo(bindable);
        }

        private void Bindable_Completed(object sender, System.EventArgs e)
        {
            var entry =(Entry) sender;
            
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.Completed -= Bindable_Completed;
            base.OnDetachingFrom(bindable);
        }

      
    }
}