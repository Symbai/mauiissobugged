using System.Collections.ObjectModel;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            var s = string.Empty;
        }
    }

    public class Bla
    {
        public static Bla Instance { get; } = new Bla();

        public Bla()
        {
            for (int i = 0; i < 20; i++)
            {
                Items.Add($"Item {i}");
            }
        }

        public ObservableCollection<string> Items { get; } = new ObservableCollection<string>();

    }

}
