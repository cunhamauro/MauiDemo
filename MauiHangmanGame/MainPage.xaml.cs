using System.ComponentModel;
using System.Diagnostics;

namespace MauiHangmanGame
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        #region UI Properties
        public string Word
        {
            get => word;
            set
            {
                word = value;
                OnPropertyChanged();
            }
        }
        public List<char> Letters
        {
            get => letters;
            set
            {
                letters = value;
                OnPropertyChanged();
            }
        }

        public string Message
        {
            get => message;
            set
            {
                message = value;
                OnPropertyChanged();
            }
        }
        public string GameStatus
        {
            get => gameStatus;
            set
            {
                gameStatus = value;
                OnPropertyChanged();
            }
        }
        public string CurrentImage
        {
            get => currentImage;
            set
            {
                currentImage = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Fields

        List<string> words = new List<string>()
            {
            "python",
            "javascript",
            "maui",
            "csharp",
            "xamarin",
            "sql",
            "xaml",
            "windows",
            "linux",
            "unity",
            };

        string answer = "";
        private string word;
        List<char> guess = new List<char>();
        private List<char> letters = new List<char>();
        private string message;
        int errors = 0;
        int maxErrors = 6;
        private string gameStatus;
        private string currentImage = "img0.jpg";

        #endregion

        public MainPage()
        {
            InitializeComponent();
            Letters.AddRange("abcdefghijklmnopqrstuvwxyz");
            BindingContext = this;
            GetGameWord();
            CalculateWord(answer, guess);
        }

        #region Jogo

        private void GetGameWord()
        {
            answer = words[new Random().Next(0, words.Count)];
        }

        private void CalculateWord(string answer, List<char> guess)
        {
            var temp = answer.Select(x => (guess.IndexOf(x) >= 0 ? x : '_')).ToArray();
            Word = string.Join(' ', temp);
        }

        private void CheckGuess(char letter)
        {
            if (guess.IndexOf(letter) == -1)
            {
                guess.Add(letter);
            }

            if (answer.IndexOf(letter) >= 0)
            {
                CalculateWord(answer, guess);
                CheckVictory();
            }
            else if (answer.IndexOf(letter) == -1) // If there is an error
            {
                errors++;
                UpdateStatus();
                CheckLoss();
                CurrentImage = $"img{errors}.jpg";
            }
        }

        private void CheckLoss()
        {
            if (errors == maxErrors)
            {
                Message = "You lost!";
                DisableLetters();
            }
        }

        private void DisableLetters()
        {
            foreach (var children in LetrasContainer.Children)
            {
                var btn = children as Button;
                if (btn != null)
                {
                    btn.IsEnabled = false;
                }
            }
        }
        private void EnableLetters()
        {
            foreach (var children in LetrasContainer.Children)
            {
                var btn = children as Button;
                if (btn != null)
                {
                    btn.IsEnabled = true;
                }
            }
        }

        private void CheckVictory()
        {
            if (Word.Replace(" ", "") == answer)
            {
                Message = "You win!";
                DisableLetters();
            }
        }

        private void UpdateStatus()
        {
            GameStatus = $"Errors: {errors} / {maxErrors}";
        }

        #endregion

        private void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (btn != null)
            {
                var letter = btn.Text;
                btn.IsEnabled = false;
                CheckGuess(letter[0]);
            }
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            errors = 0;
            guess = new List<char>();
            CurrentImage = "img0.jpg";
            GetGameWord();
            CalculateWord(answer, guess);
            Message = "";
            UpdateStatus();
            EnableLetters();
        }
    }
}