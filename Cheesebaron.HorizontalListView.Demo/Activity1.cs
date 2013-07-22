using System;
using System.Collections.Generic;
using System.Text;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace Cheesebaron.HorizontalListView.Demo
{
    [Activity(Label = "HorizontalListView Demo", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var horiListView = FindViewById<HorizontalListView>(Resource.Id.listView);

            var data = new List<string>();

            for (var i = 0; i < Random.Next(3, 10); i++)
            {
                data.Add(RandomString(Random.Next(10,20)));
            }

            horiListView.Adapter = new MyAdapter(data);

            // Only works with Snap set to true.
            horiListView.ScreenChanged += (sender, args) => 
                System.Diagnostics.Debug.WriteLine("Screen changed to " + args.CurrentScreen);
        }

        //http://stackoverflow.com/a/1122519/368379
        private static readonly Random Random = new Random((int)DateTime.Now.Ticks);
        private static string RandomString(int size)
        {
            var builder = new StringBuilder();
            for (var i = 0; i < size; i++)
            {
                builder.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(26 * Random.NextDouble() + 65))));
            }

            return builder.ToString();
        }

        private class MyAdapter: BaseAdapter<string>
        {
            private readonly IList<string> _items;

            public MyAdapter(IList<string> items)
            {
                _items = items;
            }

            public override long GetItemId(int position)
            {
                return position;
            }

            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                var retval = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.ViewItem, null);
                var id = retval.FindViewById<TextView>(Resource.Id.id);
                var str = retval.FindViewById<TextView>(Resource.Id.desc);

                id.Text = "Id " + position;
                str.Text = _items[position];

                return retval;
            }

            public override int Count
            {
                get { return _items.Count; }
            }

            public override string this[int position]
            {
                get { return _items[position]; }
            }
        }
    }
}

