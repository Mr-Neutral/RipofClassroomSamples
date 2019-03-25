using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Chapter7
{
    public class MainPageViewModel
    {
        public ObservableCollection<ItemModel> Items { get; set; }
    }
}
