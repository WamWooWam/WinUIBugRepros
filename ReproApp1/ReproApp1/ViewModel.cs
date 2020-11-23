using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproApp
{
    public class Item
    {
        public Item()
        {
            String1 = "String1";
            String2 = "String2";
            String3 = "String3";
            String4 = "String4";
            String5 = "String5";
        }

        public string String1 { get; set; }
        public string String2 { get; set; }
        public string String3 { get; set; }
        public string String4 { get; set; }
        public string String5 { get; set; }

        public SubItem SubItem { get; set; } = new SubItem();
    }

    public class SubItem
    {
        public SubItem()
        {
            String1 = "String1";
            String2 = "String2";
            String3 = "String3";
            String4 = "String4";
            String5 = "String5";
        }

        public string String1 { get; set; }
        public string String2 { get; set; }
        public string String3 { get; set; }
        public string String4 { get; set; }
        public string String5 { get; set; }
    }

    public class ViewModel
    {
        public ObservableCollection<Item> Items { get; set; }

        public ViewModel()
        {
            Items = new ObservableCollection<Item>();
            for (int i = 0; i < 1000; i++)
            {
                Items.Add(new Item());
            }
        }

    }
}
