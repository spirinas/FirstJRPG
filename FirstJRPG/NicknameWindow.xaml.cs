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
using System.Windows.Shapes;

namespace FirstJRPG
{
    /// <summary>
    /// Логика взаимодействия для NicknameWindow.xaml
    /// </summary>
    public partial class NicknameWindow : Window
    {
        public string PlayerName => NameTextBox.Text;
        public NicknameWindow()
        {
            InitializeComponent();
            NameTextBox.Focus();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameTextBox.Text))
                DialogResult = true;
            else
                MessageBox.Show("Введите имя!");
        }
        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                OkButton_Click(sender, e);
            }
        }
    }
}
