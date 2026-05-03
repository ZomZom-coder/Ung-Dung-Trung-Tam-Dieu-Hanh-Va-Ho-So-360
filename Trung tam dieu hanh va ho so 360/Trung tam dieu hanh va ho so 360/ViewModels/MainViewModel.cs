using System;
using System.Collections.Generic;
using System.Text;
using Trung_tam_dieu_hanh_va_ho_so_360.Stores;

namespace Trung_tam_dieu_hanh_va_ho_so_360.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        // Bind vào Content Control trong XAML
        public ViewModelBase CurrenViewModel => _navigationStore.CurrentViewModel;
            
       
        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;

            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrenViewModel));
        }

    }
}
