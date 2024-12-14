using System.Windows;
using System.Windows.Input;

namespace SistemaProyectoLRPD.Views
{
    /// <summary>
    /// Lógica de interacción para MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        bool M = true;
        public MainView()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void bttn_close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void bttn_Minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void bttn_MaximizeResize_Click(object sender, RoutedEventArgs e)
        {
            if (M == true)
            {
                WindowState = WindowState.Maximized;
                M = false;
            }
            else
            {
                WindowState = WindowState.Normal;
                M = true;
            }
        }
    }
}
