using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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
using Microsoft.Win32;

namespace RandomGeneration
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Dispatcher.Invoke(() =>
            {
                DropDownMenu.Items.Add("IOTA");
            });
        }

        private void GenerateBtn_Click(object sender, RoutedEventArgs e)
        {
            ClearBoxes();
            List<TextBox> list = new List<TextBox>() { Seed1 };

            FillTextBoxes(list);
        }
        private void ClearBoxes()
        {
            Dispatcher.Invoke(() =>
            {
                Seed1.Text = "";
            });
        }
        private void FillTextBoxes(List<TextBox> list)
        {
            foreach (var textbox in list)
            {
                textbox.Text = RndClassGen.RndGen(Convert.ToInt32(LengthTextBox.Text));
            }
        }

        private void Copy1_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Seed1.Text);
            Task.Run(() =>
            {
                InfoBarAsync("✓", "Copied");
            });
        }


        private async Task InfoBarAsync(string symbol, string message)
        {
            int infoBarHeight = 0;
            Dispatcher.Invoke(() =>
            {
                InfoBarBG.Visibility = Visibility.Visible;
                LabelSymbol.Foreground = Brushes.Green;

                LabelSymbol.Content = symbol;
                LabelText.Content = message;
                LabelSymbol.Visibility = Visibility.Visible;
                LabelText.Visibility = Visibility.Visible;
            });

            async Task PutTaskDelay()
            {
                await Task.Delay(15);
            }

            for (int i = 0; i < 6; i++)
            {
                Dispatcher.Invoke(() =>
                {
                    InfoBarBG.Height = infoBarHeight;
                    LabelSymbol.Height = infoBarHeight;
                    LabelText.Height = infoBarHeight;
                });
                infoBarHeight += 5;
                await PutTaskDelay();
            }
            Thread.Sleep(3000);
            Dispatcher.Invoke(() =>
            {
                InfoBarBG.Visibility = Visibility.Hidden;
                LabelSymbol.Foreground = Brushes.Green;

                LabelSymbol.Content = "";
                LabelText.Content = "";
                LabelSymbol.Visibility = Visibility.Hidden;
                LabelText.Visibility = Visibility.Hidden;
            });
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetCursorPos(ref Win32Point pt);

        [StructLayout(LayoutKind.Sequential)]
        internal struct Win32Point
        {
            public Int32 X;
            public Int32 Y;
        };
        public static Point GetMousePosition()
        {
            Win32Point w32Mouse = new Win32Point();
            GetCursorPos(ref w32Mouse);
            return new Point(w32Mouse.X, w32Mouse.Y);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string seed = "";
            Task.Run(() =>
            {
                seed = GetCursorPos();
                Dispatcher.Invoke(() =>
                    {
                        Seed1.Text = seed;
                    });
            });

        }

        public static string GetCursorPos()
        {
            string xx = "";

            Point x = GetMousePosition();

            xx = x.X.ToString();

            return xx;
        }
    }
}

