using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShopList.Maui.Models;
using ShopList.Maui.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ShopList.Maui.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ShopListltem> _items;

        public MainViewModel()
        {
            Items = new ObservableCollection<ShopListltem>();
            LoadItems();
        }

        private void LoadItems()
        {
            Items.Add(new ShopListltem
            {
                Nombre = "Leche",
                Cantidad = 2,
                Comprado = false
            });
            Items.Add(new ShopListltem
            {
                Nombre = "Pan",
                Cantidad = 1,
                Comprado = true
            });
            Items.Add(new ShopListltem
            {
                Nombre = "Harina",
                Cantidad = 3,
                Comprado = false
            });

        }

        [RelayCommand]
        private async Task ShowNewItemFormAsync()
        {
            await Shell.Current.GoToAsync(nameof(EditShopListIemPage));
        }
    }
}
