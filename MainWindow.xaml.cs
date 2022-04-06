using System;
using System.Windows;

namespace zad5
{
    public partial class MainWindow : Window
    {
        static public bool IsPreview = false;
        static Preview preview = new Preview();

        public MainWindow()
        {
            InitializeComponent();

            if(MovieList.SelectedIndex == -1)
            {
                EditButton.IsEnabled = false;
                PreviewButton.IsEnabled = false;
                DeleteButton.IsEnabled = false;
            }
        }

        private void AddMovie(object sender, RoutedEventArgs e)
        {
            AddMovie diag = new AddMovie();
            diag.Title = "Dodaj film";
            diag.Accept.Content = "Dodaj";

            if (true == diag.ShowDialog())
                MovieList.Items.Add(new Movie(diag.MovieTitle.Text, (DateTime)diag.Date.SelectedDate, diag.Desc.Text));
        }

        private void EditMovie(object sender, RoutedEventArgs e)
        {
            if (MovieList.SelectedIndex >= 0)
            {
                AddMovie diag = new AddMovie();
                diag.Title = "Edytuj film";
                diag.Accept.Content = "Edytuj";

                Movie temp = (Movie)MovieList.Items[MovieList.SelectedIndex];

                diag.MovieTitle.Text = temp.title;
                diag.Date.SelectedDate = temp.date;
                diag.Desc.Text = temp.desc;

                if (true == diag.ShowDialog())      // -- okno modalne - takie, które nie pozwala wykonywać akcji w oknie gł.
                {
                    temp.title = diag.MovieTitle.Text;
                    temp.date = (DateTime)diag.Date.SelectedDate;
                    temp.desc = diag.Desc.Text;

                    MovieList.Items[MovieList.SelectedIndex] = temp;
                    MovieList.Items.Refresh();
                }
            }
        }

        private void PreviewMovie(object sender, RoutedEventArgs e)
        {
            if (MovieList.SelectedIndex >= 0 && IsPreview == false)
            {
                IsPreview = true;
                preview = new Preview((Movie)MovieList.SelectedItem);
                preview.Show();                // -- okno niemodalne - takie, które pozwala klikać w oknie gł.
            }
        }

        private void RemoveMovie(object sender, RoutedEventArgs e)
        {
            if (MovieList.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Czy na pewno chcesz usunąć wybrany film?", "Usuń film", MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes) //Pokazuje okno dialogoawe" czy na peno usuąć?" Parametry: Tekst wiadomości, Nagłówek okna, Jaki jest typ przycisków, Obrazek
                    return;
                MovieList.Items.RemoveAt(MovieList.SelectedIndex);
            }
        }

        private void ChangeElement(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (!IsPreview)
                preview = new Preview();
            if(MovieList.SelectedIndex >=0)
            {
                Movie temp = (Movie)MovieList.SelectedItem;
                preview.MoviePreview.Content = temp.PreviewInformation();

                EditButton.IsEnabled = true;
                PreviewButton.IsEnabled = true;
                DeleteButton.IsEnabled = true;
            }
            else
            {
                EditButton.IsEnabled = false;
                PreviewButton.IsEnabled = false;
                DeleteButton.IsEnabled = false;
            }
        }
    }
}
