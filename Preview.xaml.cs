using System;
using System.Windows;

namespace zad5
{
    public partial class Preview : Window
    {
        public Preview()
        {
            InitializeComponent();
        }

        public Preview(Movie movie)
        {
            InitializeComponent();
            MoviePreview.Content = movie.PreviewInformation();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        { }

       /* private void Ok(object sender, RoutedEventArgs e)
        {
            MainWindow.IsPreview = false;
            Close();
        }*/

        private void ClosePreview(object sender, EventArgs e)
        {
            MainWindow.IsPreview = false;
            Close();
        }
    }
}
