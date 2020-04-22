using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ArduinoJoystick
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            (DataContext as MainWindowViewModel).LoadAvailableComPorts();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            SetLabelBGColor(e.Key, Brushes.Gray);
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            SetLabelBGColor(e.Key, Brushes.White);
        }

        private void SetLabelBGColor(Key k, Brush color)
        {
            switch (k)
            {
                case Key.NumPad1:
                case Key.D1:
                    Key1Label.Background = color;
                    (DataContext as MainWindowViewModel).SendComMessage("1");
                    break;

                case Key.NumPad2:
                case Key.D2:
                    Key2Label.Background = color;
                    (DataContext as MainWindowViewModel).SendComMessage("2");
                    break;

                case Key.NumPad3:
                case Key.D3:
                    Key3Label.Background = color;
                    (DataContext as MainWindowViewModel).SendComMessage("3");
                    break;

                case Key.NumPad4:
                case Key.D4:
                    Key4Label.Background = color;
                    (DataContext as MainWindowViewModel).SendComMessage("4");
                    break;

                case Key.NumPad5:
                case Key.D5:
                    Key5Label.Background = color;
                    (DataContext as MainWindowViewModel).SendComMessage("5");
                    break;

                case Key.NumPad6:
                case Key.D6:
                    Key6Label.Background = color;
                    (DataContext as MainWindowViewModel).SendComMessage("6");
                    break;

                case Key.NumPad7:
                case Key.D7:
                    Key7Label.Background = color;
                    (DataContext as MainWindowViewModel).SendComMessage("7");
                    break;

                case Key.NumPad8:
                case Key.D8:
                    Key8Label.Background = color;
                    (DataContext as MainWindowViewModel).SendComMessage("8");
                    break;

                case Key.NumPad9:
                case Key.D9:
                    Key9Label.Background = color;
                    (DataContext as MainWindowViewModel).SendComMessage("9");
                    break;
            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            (sender as TextBox).ScrollToEnd();
        }
    }
}
