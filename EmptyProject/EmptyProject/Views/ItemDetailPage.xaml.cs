﻿using EmptyProject.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace EmptyProject.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}