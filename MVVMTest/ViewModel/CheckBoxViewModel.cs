using System.ComponentModel;
using System.Windows.Input;
using MVVMTest.Model;

namespace MVVMTest.ViewModel
{
    public class CheckBoxViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged RaisePropertyChanged(实现INotifyPropertyChanged)

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region threeCheckBox (INotifyPropertyChanged Property)(threeCheckBox)

        private int _threeCheckBox;

        public int threeCheckBox
        {
            get { return _threeCheckBox; }
            set
            {
                if (_threeCheckBox != null && _threeCheckBox.Equals(value)) return;
                _threeCheckBox = value;
                RaisePropertyChanged("threeCheckBox");
            }
        }

        #endregion

        #region CheckBoxCommand

        private RelayCommand _checkBoxCommand;

        public ICommand CheckBoxCommand
        {
            get
            {
                if (_checkBoxCommand == null)
                    _checkBoxCommand = new RelayCommand(param => SelectedAllCheckBox(param));
                return _checkBoxCommand;
            }
        }

        private void SelectedAllCheckBox(object param)
        {
            threeCheckBox = 2;
        }

        #endregion
    }
}