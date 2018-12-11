using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace lab8Excersise3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<String> eventList = new ObservableCollection<string>();

        Random chipGenerator = new Random();

        int chips;
        int currentBet;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Create Random Amount of chips

            chips = chipGenerator.Next(100, 1000);
            tblkChips.Text = chips.ToString();

            //Write into Observable Collection rules

            string rules1 = "Welcome to Conor's Casino";
            string rules2 = "Please Click on Bet Buttons to add chips to your Current Bet";
            string rules3 = "Use the drop down menu to pick what number you want to bet on";
            string rules4 = "When you have finished your bet press Place Bet to Spin The Wheel";

            //Display Observable collection to listBox
            eventList.Add(rules1);
            eventList.Add(rules2);
            eventList.Add(rules3);
            eventList.Add(rules4);
            lbxEventList.ItemsSource = eventList;

            //Adding Values to Combo Box
            int[] betPlacement = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            cbxBetOn.ItemsSource = betPlacement;
            cbxBetOn.SelectedIndex = 0;

        }

        private void btnBet1_Click(object sender, RoutedEventArgs e)
        {
            

            //Check if User has enough chips
            if(chips >= 1)
            {
                //Take chips out of users current chips total
                chips -= 1;
                //Add it to current bet
                currentBet += 1;
                eventList.Add("Added 1 Chip to Current Bet");
            }
            else
            {
                eventList.Add("Not Enough Chips Available");
            }

            //Update all Data on screen
            tblkChips.Text = chips.ToString();
            tblkCurrentBet.Text = currentBet.ToString();
            lbxEventList.ItemsSource = eventList;

        }

        private void btnBet5_Click(object sender, RoutedEventArgs e)
        {
            //Check if User has enough chips
            if (chips >= 5)
            {
                //Take chips out of users current chips total
                chips -= 5;
                //Add it to current bet
                currentBet += 5;
                eventList.Add("Added 5 Chips to Current Bet");
            }
            else
            {
                eventList.Add("Not Enough Chips Available");
            }

            //Update all Data on screen
            tblkChips.Text = chips.ToString();
            tblkCurrentBet.Text = currentBet.ToString();
            lbxEventList.ItemsSource = eventList;
        }

        private void btnBet10_Click(object sender, RoutedEventArgs e)
        {
            //Check if User has enough chips
            if (chips >= 10)
            {
                //Take chips out of users current chips total
                chips -= 10;
                //Add it to current bet
                currentBet += 10;
                eventList.Add("Added 10 Chips to Current Bet");
            }
            else
            {
                eventList.Add("Not Enough Chips Available");
            }

            //Update all Data on screen
            tblkChips.Text = chips.ToString();
            tblkCurrentBet.Text = currentBet.ToString();
            lbxEventList.ItemsSource = eventList;
        }

        private void btnPlaceBet_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
