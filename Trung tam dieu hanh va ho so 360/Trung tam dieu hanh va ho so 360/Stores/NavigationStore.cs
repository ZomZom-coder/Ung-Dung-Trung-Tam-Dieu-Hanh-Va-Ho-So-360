using System;
using System.Collections.Generic;
using System.Text;
using Trung_tam_dieu_hanh_va_ho_so_360.ViewModels;

namespace Trung_tam_dieu_hanh_va_ho_so_360.Stores
{
    public class NavigationStore
    {
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                // Dọn dẹp View cũ để tránh rò rỉ bộ nhớ
                _currentViewModel?.Dispose();
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        public event Action CurrentViewModelChanged;

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
