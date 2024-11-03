using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ValueConverterEX.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        /// <summary>
        /// 輸入欄位
        /// </summary>
        private string _InputText;
        /// <summary>
        /// 輸入
        /// </summary>
        public string InputText
        {
            get { return _InputText; }
            set => SetProperty(ref _InputText, value);
        }
        /// <summary>
        /// 輸入確認欄位
        /// </summary>
        private string _ConfirmText;
        /// <summary>
        /// 輸入確認
        /// </summary>
        public string ConfirmText
        {
            get { return _ConfirmText; }
            set=> SetProperty(ref _ConfirmText, value);
        }
        public ICommand Click { get; set; }
        public MainWindowViewModel() 
        {
            Click = new DelegateCommand(ShowInput);
        }
        private void ShowInput()
        {
            ConfirmText = InputText;
        }
    }
}
