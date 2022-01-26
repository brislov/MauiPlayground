using System.Windows.Input;

namespace MauiPlayground.ViewModels
{
    internal class CountViewModel : BindableObject
    {
        private int count;
        private string displayCount = "Click the button!";
        public string DisplayCount
        {
            get => displayCount;
            set
            {
                displayCount = value;
                OnPropertyChanged();
            }
        }
        public ICommand IncreaseCount { get; }

        public CountViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
        }

        void OnIncrease()
        {
            count++;
            DisplayCount = $"Current count: {count}";
        }
    }
}
