using System;
using System.Collections.Generic;
using System.Text;
using Trung_tam_dieu_hanh_va_ho_so_360.Stores;
using Trung_tam_dieu_hanh_va_ho_so_360.ViewModels;

namespace Trung_tam_dieu_hanh_va_ho_so_360.Services
{
    public class NavigationService<TViewModel> where TViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<TViewModel> _createViewModel;

        public NavigationService(NavigationStore navigationStore, Func<TViewModel> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigate()
        {
            _navigationStore.CurrentViewModel = _createViewModel();
        }
    }
}
