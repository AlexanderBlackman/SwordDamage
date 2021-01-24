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

namespace DamageCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        


        public MainWindow()
        {
            InitializeComponent();
      //      swordDamage.SetMagic(magicbox.IsChecked.Value);
       //     swordDamage.SetFlaming(magicbox.IsChecked.Value);
            BladeDamage bladeDamage = new BladeDamage(RollDice(3));
            ArrowDamage arrowDamage = new ArrowDamage(RollDice(1));
        }
        /// <summary>
        /// Returns the sum of some dice.
        /// </summary>
        /// <param name="number">How many dice</param>
        /// <param name="faces">How many faces</param>
        /// <returns></returns>
  /*      public int Dice(int number = 1, int faces = 6)
        {
            int result = 0;
            for (int i = 0; i <= number; i++)
            {
                result += random.Next(1, faces + 1);
            }
            return result;
        }
  */


        public int RollDice(int number = 1, int faces = 6)
        {
            int result = 0;
            for (int i = 0; i <= number; i++)
            {
                result += random.Next(1, faces + 1);
            }
            return result;
        }

   /*     public void selectWeapon()
        {
            WeaponDamage chosenWeapon;
            switch (weaponTypeBox.SelectedItem)
            {
                case "Blade Damage":
                    WeaponDamage chosenWeapon = magic ;

                default:
                    break;
            }
        }*/
        void DisplayDamage()
        {
            damageResultBox.Text = "Rolled " + swordDamage.Roll + " for " + swordDamage.Damage + " HP";
        }

        private void rollButton_Click(object sender, RoutedEventArgs e)
        {
            RollDice();
        }

        private void flamingbox_Checked(object sender, RoutedEventArgs e)
        {
            this.Flaming = true;
            DisplayDamage();
        }

        private void flamingbox_Unchecked(object sender, RoutedEventArgs e)
        {
            swordDamage.Flaming = false;
            DisplayDamage();
        }

        private void magicbox_Checked(object sender, RoutedEventArgs e)
        {
            swordDamage.Magic = true;
            DisplayDamage();
        }

        private void Magic_Unchecked(object sender, RoutedEventArgs e)
        {
            //Remember properties are set like variables, not methods
            swordDamage.Magic = false;
            DisplayDamage();
        }
    }
}


