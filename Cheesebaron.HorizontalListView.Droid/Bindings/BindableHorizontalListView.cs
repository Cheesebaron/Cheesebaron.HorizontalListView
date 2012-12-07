using System.Collections;
using Android.Content;
using Android.Util;
using Cirrious.MvvmCross.Binding.Android;
using Cirrious.MvvmCross.Binding.Android.Views;
using Cirrious.MvvmCross.Interfaces.Commands;

namespace Cheesebaron.HorizontalListView.Droid.Bindings
{
    public class BindableHorizontalListView
        : HorizontalListView
    {
        public BindableHorizontalListView(Context context, IAttributeSet attrs) 
            : this(context, attrs, new MvxBindableListAdapter(context))
        {
        }

        public BindableHorizontalListView(Context context, IAttributeSet attrs, MvxBindableListAdapter adapter)
            : base(context, attrs)
        {
            var itemTemplateId = MvxBindableListViewHelpers.ReadAttributeValue(context, attrs, MvxAndroidBindingResource.Instance.BindableListViewStylableGroupId, MvxAndroidBindingResource.Instance.BindableListItemTemplateId);
            adapter.ItemTemplateId = itemTemplateId;
            Adapter = adapter;
            SetupItemClickListener(); 
        }

        public new MvxBindableListAdapter Adapter
        {
            get { return base.Adapter as MvxBindableListAdapter; }
            set
            {
                var existing = Adapter;
                if (existing == value)
                    return;

                if (existing != null && value != null)
                {
                    value.ItemsSource = existing.ItemsSource;
                    value.ItemTemplateId = existing.ItemTemplateId;
                }

                base.Adapter = value;
            }
        }

        //[MvxSetToNullAfterBinding]
        public IList ItemsSource
        {
            get { return Adapter.ItemsSource; }
            set { Adapter.ItemsSource = value; }
        }

        public int ItemTemplateId
        {
            get { return Adapter.ItemTemplateId; }
            set { Adapter.ItemTemplateId = value; }
        }

        public new IMvxCommand ItemClick { get; set; }

        private void SetupItemClickListener()
        {
            base.ItemClick += (sender, args) =>
            {
                if (ItemClick == null)
                    return;
                var item = Adapter.GetItem(args.Position) as MvxJavaContainer;
                if (item == null)
                    return;

                if (item.Object == null)
                    return;

                if (!ItemClick.CanExecute(item.Object))
                    return;

                ItemClick.Execute(item.Object);
            };
        }
    }
}