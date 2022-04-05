using System.Windows;

namespace zad5
{
    public partial class AddMovie : Window
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MovieTitle.SelectionLength = MovieTitle.Text.Length;
            Desc.SelectionLength = Desc.Text.Length;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            if(MovieTitle.Text.Length <= 0)
            {
                MessageBox.Show("Musisz podać nazwę filmu!", "Ostrzeżenie", MessageBoxButton.OK, MessageBoxImage.Warning);
                MovieTitle.Focus();
            }

            else if (Date.SelectedDate == null)
            {
                MessageBox.Show("Musisz podać date!", "Ostrzeżenie", MessageBoxButton.OK, MessageBoxImage.Warning);
                Date.Focus();
            }

            else if (Desc.Text.Length <= 0)
            {
                MessageBox.Show("Musisz podać opis filmu!", "Ostrzeżenie", MessageBoxButton.OK, MessageBoxImage.Warning);
                Desc.Focus();
            }

            else
                DialogResult = true;
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
