using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GuessFont.Model;

namespace GuessFont.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        #region Fields

        private FontModel _fontModel;
        private string _guessFontFamily;
        private string _guessFontSize;
        private string _guessFontStyle;
        private string _guessForeground;

        #endregion

        #region Constructor

        public MainViewModel()
        {
            FontModelProp = new FontModel();
            GuessCommand = new GalaSoft.MvvmLight.CommandWpf.RelayCommand(Guess);
            MessageBox.Show($"{FontModelProp.FontFamily} {FontModelProp.FontSize} {FontModelProp.FontStyle}  {FontModelProp.Foreground} ");
        }

        #endregion

        #region Methods

        private void Guess()
        {
            if (FontModelProp.Guess(GuessFontFamily, GuessFontSize, GuessFontStyle, GuessForeground))
            {
                MessageBox.Show("Congratulations, correct!");
                StartAgain();
            }
            else
            {
                MessageBox.Show("Wrong, try again");
            }
        }

        private void StartAgain()
        {
            FontModelProp = new FontModel();
            GuessFontFamily = string.Empty;
            GuessFontSize = string.Empty;
            GuessFontStyle = string.Empty;
            GuessForeground = string.Empty;
        }

        #endregion

        #region Properties

        public FontModel FontModelProp
        {
            get => _fontModel;
            set
            {
                _fontModel = value;
                RaisePropertyChanged(nameof(FontModelProp));
            }
        }

        public ICommand GuessCommand { get; }

        public string GuessFontFamily
        {
            get => _guessFontFamily;
            set
            {
                _guessFontFamily = value;
                RaisePropertyChanged(nameof(GuessFontFamily));
            }
        }

        public string GuessFontSize
        {
            get => _guessFontSize;
            set
            {
                _guessFontSize = value;
                RaisePropertyChanged(nameof(GuessFontSize));
            }
        }

        public string GuessFontStyle
        {
            get => _guessFontStyle;
            set
            {
                _guessFontStyle = value;
                RaisePropertyChanged(nameof(GuessFontStyle));
            }
        }

        public string GuessForeground
        {
            get => _guessForeground;
            set
            {
                _guessForeground = value;
                RaisePropertyChanged(nameof(GuessForeground));
            }
        }

        #endregion
    }
}