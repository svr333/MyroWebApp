﻿using System;

using MyroWebApp.Xamarin.Models;

namespace MyroWebApp.Xamarin.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
