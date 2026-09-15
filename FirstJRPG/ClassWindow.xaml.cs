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
    /// Логика взаимодействия для ClassWindow.xaml
    /// </summary>
    public partial class ClassWindow : Window
    {
        public string SelectedClass { get; private set; } = "Warrior";
        public ClassWindow()
        {
            InitializeComponent();
        }

        private void ClassButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            SelectedClass = button.Content.ToString();

            switch (SelectedClass)
            {
                case "Warrior":
                    DescriptionTextBlock.Text = "Сильный и выносливый боец. Использует тяжелое оружие и доспехи."; break;
                case "Wizard":
                    DescriptionTextBlock.Text = "Умный и талантливый маг. Использует посохи и мантии"; break;
                case "Archery":
                    DescriptionTextBlock.Text = "Ловкий и меткий лучник. Использует луки и лёгкую броню"; break;

            }
        }
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
