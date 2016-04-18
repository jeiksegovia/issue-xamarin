using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace test
{
	public class MyPage : ContentPage
	{
		ListView list;
		public MyPage ()
		{
			List<string[]> array = new List<string[]>(){
				new string[]{"1", "hello"},
				new string[]{"2", "world"},
				new string[]{"3", "hello"}
			};

			list=new ListView();

			var cell = new DataTemplate (typeof(TextCell));
			cell.SetBinding (TextCell.TextProperty,".[1]");
			list.ItemTemplate = cell;

			list.ItemsSource = array;

			Content = list;
		}
	}
}


