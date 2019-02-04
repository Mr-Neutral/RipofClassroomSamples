using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Chapter3
{
	public class GridPageCSharp : ContentPage
	{
		public GridPageCSharp ()
		{
            var grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(100) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };

            var label = new Label { Text = "Cell 1, 1" };

            grid.Children.Add(view: label, left: 0, top: 0);

            grid.Children.Add(new Label { Text = "Cell 1, 2" }, 1, 0);
            grid.Children.Add(new Label { Text = "Cell 1, 3" }, 2, 0);
            grid.Children.Add(new Label { Text = "Cell 2, 1" }, 0, 1);
            grid.Children.Add(new Label { Text = "Cell 2, 2" }, 1, 1);
            grid.Children.Add(new Label { Text = "Cell 2, 3" }, 2, 1);

            Content = grid;
        }
	}
}