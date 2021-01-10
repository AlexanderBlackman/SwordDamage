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

namespace SwordDamage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        Damage swordDamage = new Damage();

        public MainWindow()
        {
            InitializeComponent();
            swordDamage.SetMagic(magicbox.IsChecked.Value);
            swordDamage.SetFlaming(magicbox.IsChecked.Value);
            RollDice();
        }

        public void RollDice()
        {
            swordDamage.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            swordDamage.SetFlaming(flamingbox.IsChecked.Value);
            swordDamage.SetMagic(magicbox.IsChecked.Value);
            DisplayDamage();
        }

        void DisplayDamage()
        {
            damageResultBox.Text = "Rolled " + swordDamage.Roll + " for " + swordDamage.TotalDamage + " HP";
        }

        private void rollButton_Click(object sender, RoutedEventArgs e)
        {
            RollDice();
        }

        private void flamingbox_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.SetFlaming(true);
            DisplayDamage();
        }

        private void flamingbox_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.SetFlaming(false);
            DisplayDamage();
        }

        private void magicbox_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.SetMagic(true);
            DisplayDamage();
        }

        private void Magic_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.SetMagic(false);
            DisplayDamage();
        }
    }
}


