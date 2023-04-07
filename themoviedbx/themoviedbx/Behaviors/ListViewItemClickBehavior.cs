using System;
using Xamarin.Forms;

namespace themoviedbx.Behaviors
{
    public class ListViewItemClickBehavior : Behavior<ListView>
    {
        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.ItemTapped += OnItemTapped;
        }

        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.ItemTapped -= OnItemTapped;
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (sender is ListView listView && listView.SelectedItem != null)
            {
                if (e.Item != null)
                {
                    var vm = listView.BindingContext;
                    //vm?.ItemTappedCommand?.Execute(item);
                }
                listView.SelectedItem = null;
            }
        }
    }
}

