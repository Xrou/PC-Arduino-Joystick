using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ArduinoJoystick
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        #region property changed event
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion

        public ObservableCollection<string> AvailableComPorts { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<string> AvailableBaudRate { get; set; } = new ObservableCollection<string>() { "300", "1000", "1200", "2400", "4800", "9600", "19200", "38400", "57600", "74880", "115200", "230400", "250000", "500000", "1000000", "2000000" };
        public string LogText
        {
            get
            {
                return logText;
            }
            set
            {
                logText = value;
                OnPropertyChanged("LogText");
            }
        }
        public string SelectedComPort
        {
            get { return selectedComPort; }
            set
            {
                selectedComPort = value;
                if (CurrentPort != null && CurrentPort.IsOpen)
                    ConnectDisconnect();
                OnPropertyChanged("SelectedComPort");
            }
        }
        public string SelectedBaudRate
        {
            get { return selectedBaudRate.ToString(); }
            set
            {
                selectedBaudRate = Convert.ToInt32(value);
                if (CurrentPort != null && CurrentPort.IsOpen)
                    ConnectDisconnect();
                OnPropertyChanged("SelectedBaudRate");
            }
        }
        public string ConnectedDisconnectedPath { get { return connectedDisconnectedPath; } set { connectedDisconnectedPath = value; OnPropertyChanged(); } }

        private string logText;
        private string selectedComPort;
        private string connectedDisconnectedPath = "disconnect.jpg";
        private int selectedBaudRate = 9600;
        private static SerialPort CurrentPort;

        public Command ConnectCommand
        {
            get
            {
                return new Command(obj =>
                {
                    ConnectDisconnect();
                });
            }
        }

        public Task PortReader;

        public void LoadAvailableComPorts()
        {
            string[] ports = SerialPort.GetPortNames();

            var autoPort = (from p in ports where !p.Contains("COM1") select p);

            if (autoPort.Count() != 0)
                SelectedComPort = autoPort.Last();

            foreach (var p in ports)
            {
                AvailableComPorts.Add(p);
            }
        }
        public void ConnectDisconnect()
        {
            try
            {
                if (CurrentPort == null || !CurrentPort.IsOpen)
                {
                    if (SelectedComPort != null)
                    {
                        CurrentPort = new SerialPort(SelectedComPort, selectedBaudRate);
                        CurrentPort.Open();
                        LogText = "";
                        PortReader = Task.Factory.StartNew(() =>
                        {
                            ReadPort();
                        });
                        ConnectedDisconnectedPath = "connect.jpg";
                    }
                    else
                    {
                        MessageBox.Show("Не выбран COM порт", "XRou / PC-Arduino Joystick", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                else
                {
                    CurrentPort.Close();
                    ConnectedDisconnectedPath = "disconnect.jpg";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно подключиться к COM порту. Проверьте отсутствие включенных программ, работающих с этим COM портом");
            }
        }
        public void SendComMessage(string text)
        {
            if (CurrentPort != null && CurrentPort.IsOpen)
            {
                CurrentPort.Write(text);
            }
        }

        public void ReadPort()
        {
            while (true)
            {
                try
                {
                    if (CurrentPort.IsOpen)
                    {
                        int count = CurrentPort.BytesToRead;

                        if (count > 0)
                        {
                            byte[] ByteArray = new byte[count];
                            CurrentPort.Read(ByteArray, 0, count);

                            string text = Encoding.UTF8.GetString(ByteArray);
                            if (LogText.Length > 100)
                            {
                                LogText = LogText.Substring(80, 20);
                            }
                            LogText += text;
                        }
                    }
                }
                catch { }
            }
        }
    }
}
