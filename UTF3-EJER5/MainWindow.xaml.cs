
using System.Windows;
using System.Windows.Controls;


namespace UTF3_EJER5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resultadoTextBlock.Text += (sender as Button).Tag.ToString();


        }
    }
}
