using System;
using GalaSoft.MvvmLight;

namespace GuessFont.Model
{
    public class FontModel : ViewModelBase
    {
        #region Fields

        private readonly Random _random = new Random();
        private string _fontFamily;
        private string _fontSize;
        private string _fontStyle;
        private string _foreground;

        #endregion

        #region Constructor

        public FontModel()
        {
            FontFamily = RandomFontFamily();
            FontSize = RandomFontSize();
            FontStyle = RandomFontStyle();
            Foreground = RandomForeground();
        }

        #endregion

        #region Methods

        private string RandomFontFamily()
        {
            var rnd = _random.Next(1, 3);

            switch (rnd)
            {
                case 1:
                    return "Algerian";
                case 2:
                    return "Comic Sans MS";
                case 3:
                    return "Georgia";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private string RandomFontSize()
        {
            var rnd = _random.Next(1, 3);

            switch (rnd)
            {
                case 1:
                    return "12";
                case 2:
                    return "24";
                case 3:
                    return "36";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private string RandomFontStyle()
        {
            var rnd = _random.Next(1, 3);

            switch (rnd)
            {
                case 1:
                    return "Italic";
                case 2:
                    return "Normal";
                case 3:
                    return "Oblique";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private string RandomForeground()
        {
            var rnd = _random.Next(1, 7);

            switch (rnd)
            {
                case 1:
                    return "Red";
                case 2:
                    return "Orange";
                case 3:
                    return "Yellow	";
                case 4:
                    return "Green";
                case 5:
                    return "Blue";
                case 6:
                    return "Indigo";
                case 7:
                    return "Violet";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public bool Guess(string fontFamily, string fontSize, string fontStyle, string foreground)
        {
            return fontFamily == FontFamily || fontSize == FontSize || fontStyle == FontStyle ||
                   foreground == Foreground;
        }

        #endregion

        #region Properties

        public string FontFamily
        {
            get => _fontFamily;
            set => Set(ref _fontFamily, value);
        }

        public string FontSize
        {
            get => _fontSize;
            set => Set(ref _fontSize, value);
        }

        public string FontStyle
        {
            get => _fontStyle;
            set => Set(ref _fontStyle, value);
        }

        public string Foreground
        {
            get => _foreground;
            set => Set(ref _foreground, value);
        }

        #endregion
    }
}
