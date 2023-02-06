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

namespace Imposible_TicTacToe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window/// Вашему вниманию представляется самый ужастный код который вы видели
    {
        public string Move = "X";
        public string BotMove = "O";
        public MainWindow()///Какой-то ультра кринж я не могу
        {
 
            InitializeComponent();
            lockPanels();
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            unlockPanels();
        }
        private void BotinokMove()
        {
            WinLose();
            Random rnd= new Random();
            int rndNum = rnd.Next(10);
            if (rndNum == 1)
            {
                if (ButtonCross.Content == "")
                {
                    ButtonCross.Content = BotMove;
                    ButtonCross.IsEnabled= false;
                }
                else
                {
                    BotinokMove();
                }
            }
            else if (rndNum == 2)
            {
                if (ButtonCross_Copy.Content == "")
                {
                    ButtonCross_Copy.Content = BotMove;
                    ButtonCross_Copy.IsEnabled= false;
                }
                else
                {
                    BotinokMove();
                }
            }
            else if (rndNum == 3)
            {
                if (ButtonCross_Copy1.Content == "")
                {
                    ButtonCross_Copy1.Content = BotMove;
                    ButtonCross_Copy1.IsEnabled= false;
                }
                else
                {
                    BotinokMove();
                }
            }
            else if (rndNum == 4)
            {
                if (ButtonCross_Copy2.Content == "")
                {
                    ButtonCross_Copy2.Content = BotMove;
                    ButtonCross_Copy2.IsEnabled= false;
                }
                else
                {
                    BotinokMove();
                }
            }
            else if (rndNum == 5)
            {
                if (ButtonCross_Copy3.Content == "")
                {
                    ButtonCross_Copy3.Content = BotMove;
                    ButtonCross_Copy3.IsEnabled= false;
                }
                else
                {
                    BotinokMove();
                }
            }
            else if (rndNum == 6)
            {
                if (ButtonCross_Copy4.Content == "")
                {
                    ButtonCross_Copy4.Content = BotMove;
                    ButtonCross_Copy4.IsEnabled= false;
                }
                else
                {
                    BotinokMove();
                }
            }
            else if (rndNum == 7)
            {
                if (ButtonCross_Copy5.Content == "")
                {
                    ButtonCross_Copy5.Content = BotMove;
                    ButtonCross_Copy5.IsEnabled= false;
                }
                else
                {
                    BotinokMove();
                }
            }
            else if (rndNum == 8)
            {
                if (ButtonCross_Copy6.Content == "")
                {
                    ButtonCross_Copy6.Content = BotMove;
                    ButtonCross_Copy6.IsEnabled= false;
                }
                else
                {
                    BotinokMove();
                }
            }
            else if (rndNum == 9)
            {
                if (ButtonCross_Copy7.Content == "")
                {
                    ButtonCross_Copy7.Content = BotMove;
                    ButtonCross_Copy7.IsEnabled= false;
                }
                else
                {
                    BotinokMove();
                }
            }
            }
        private void ButtonCross_Click(object sender, RoutedEventArgs e)
        {
            ButtonCross.Content = Move;
            BotinokMove();
        }///Ну что это

        private void ButtonCross_Copy_Click(object sender, RoutedEventArgs e)
        {
            ButtonCross_Copy.Content= Move;
            BotinokMove();
        }

        private void ButtonCross_Copy1_Click(object sender, RoutedEventArgs e)
        {
            ButtonCross_Copy1.Content = Move;
            BotinokMove();
        }

        private void ButtonCross_Copy4_Click(object sender, RoutedEventArgs e)
        {
            ButtonCross_Copy4.Content = Move;
            BotinokMove();
        }

        private void ButtonCross_Copy3_Click(object sender, RoutedEventArgs e)
        {
            ButtonCross_Copy3.Content = Move;
            BotinokMove();
        }

        private void ButtonCross_Copy2_Click(object sender, RoutedEventArgs e)
        {
            ButtonCross_Copy2.Content = Move;
            BotinokMove();
        }

        private void ButtonCross_Copy5_Click(object sender, RoutedEventArgs e)
        {
            ButtonCross_Copy5.Content = Move;
            BotinokMove();
        }

        private void ButtonCross_Copy6_Click(object sender, RoutedEventArgs e)
        {
            ButtonCross_Copy6.Content = Move;
            BotinokMove();
        }

        private void ButtonCross_Copy7_Click(object sender, RoutedEventArgs e)
        {
            ButtonCross_Copy7.Content = Move;
            BotinokMove();
        }

        private void StartGame_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Move=="O" && BotMove=="X") 
            {
                Move = "X";
                BotMove = "O";
            }
            else
            {
                Move = "O";
                BotMove = "X";
            }
            MessageBox.Show($"Вы: {Move}");
            ClearButtons();
        }
        private void WinLose()
        {
            if (ButtonCross.Content == Move && ButtonCross_Copy.Content == Move && ButtonCross_Copy1.Content == Move)
            {
                MessageBox.Show("Вы победили!");
                ClearButtons();
            }
            else if (ButtonCross_Copy4.Content == Move && ButtonCross_Copy3.Content == Move && ButtonCross_Copy2.Content == Move)
            {
                MessageBox.Show("Вы победили!");
                ClearButtons();
            }
            else if (ButtonCross_Copy5.Content == Move && ButtonCross_Copy6.Content == Move && ButtonCross_Copy7.Content == Move)
            {
                MessageBox.Show("Вы победили!");
                ClearButtons();
            }
            else if (ButtonCross.Content==Move && ButtonCross_Copy4.Content==Move && ButtonCross_Copy5.Content == Move)
            {
                MessageBox.Show("Вы победили!");
                ClearButtons();
            }
            else if (ButtonCross_Copy.Content == Move && ButtonCross_Copy3.Content == Move && ButtonCross_Copy6.Content == Move)
            {
                MessageBox.Show("Вы победили!");
                ClearButtons();
            }
            else if (ButtonCross_Copy1.Content == Move && ButtonCross_Copy2.Content == Move && ButtonCross_Copy7.Content == Move)
            {
                MessageBox.Show("Вы победили!");
                ClearButtons();
            }
            else if (ButtonCross.Content == Move && ButtonCross_Copy3.Content == Move && ButtonCross_Copy7.Content == Move)
            {
                MessageBox.Show("Вы победили!");
                ClearButtons();
            } 
            else if(ButtonCross_Copy1.Content==Move && ButtonCross_Copy3.Content==Move && ButtonCross_Copy5.Content == Move) 
            {
                MessageBox.Show("Вы победили!");
                ClearButtons();
            }
            else if (ButtonCross.Content == BotMove && ButtonCross_Copy.Content == BotMove && ButtonCross_Copy1.Content == BotMove)
            {
                MessageBox.Show("Вы проиграли!");
                ClearButtons();
            }
            else if (ButtonCross_Copy4.Content == BotMove && ButtonCross_Copy3.Content == BotMove && ButtonCross_Copy2.Content == BotMove)
            {
                MessageBox.Show("Вы проиграли!");
                ClearButtons();
            }
            else if (ButtonCross_Copy5.Content == BotMove && ButtonCross_Copy6.Content == BotMove && ButtonCross_Copy7.Content == BotMove)
            {
                MessageBox.Show("Вы проиграли!");
                ClearButtons();
            }
            else if (ButtonCross.Content == BotMove && ButtonCross_Copy4.Content == BotMove && ButtonCross_Copy5.Content == BotMove)
            {
                MessageBox.Show("Вы проиграли!");
                ClearButtons();
            }
            else if (ButtonCross_Copy.Content == BotMove && ButtonCross_Copy3.Content == BotMove && ButtonCross_Copy6.Content == BotMove)
            {
                MessageBox.Show("Вы проиграли!");
                ClearButtons();
            }
            else if (ButtonCross_Copy1.Content == BotMove && ButtonCross_Copy2.Content == BotMove && ButtonCross_Copy7.Content == BotMove)
            {
                MessageBox.Show("Вы проиграли!");
                ClearButtons();
            }
            else if (ButtonCross.Content == BotMove && ButtonCross_Copy3.Content == BotMove && ButtonCross_Copy7.Content == BotMove)
            {
                MessageBox.Show("Вы проиграли!");
                ClearButtons();
            }
            else if (ButtonCross_Copy1.Content == BotMove && ButtonCross_Copy3.Content == BotMove && ButtonCross_Copy5.Content == BotMove)
            {
                MessageBox.Show("Вы проиграли!");
                ClearButtons();
            }


        }
        private void ClearButtons()
        {
            lockPanels();
            ButtonCross.Content = "";
            ButtonCross_Copy.Content = "";
            ButtonCross_Copy1.Content = "";
            ButtonCross_Copy2.Content = "";
            ButtonCross_Copy3.Content = "";
            ButtonCross_Copy4.Content = "";
            ButtonCross_Copy5.Content = "";
            ButtonCross_Copy6.Content = "";
            ButtonCross_Copy7.Content = "";
        }
        private void lockPanels()
        {
            ButtonCross.IsEnabled = false;
            ButtonCross_Copy.IsEnabled = false;
            ButtonCross_Copy1.IsEnabled = false;
            ButtonCross_Copy2.IsEnabled = false;
            ButtonCross_Copy3.IsEnabled = false;
            ButtonCross_Copy4.IsEnabled = false;
            ButtonCross_Copy5.IsEnabled = false;
            ButtonCross_Copy6.IsEnabled = false;
            ButtonCross_Copy7.IsEnabled = false;

        }
        private void unlockPanels()
        {
            ButtonCross.IsEnabled = true;
            ButtonCross_Copy.IsEnabled = true;
            ButtonCross_Copy1.IsEnabled = true;
            ButtonCross_Copy2.IsEnabled = true;
            ButtonCross_Copy3.IsEnabled = true;
            ButtonCross_Copy4.IsEnabled = true;
            ButtonCross_Copy5.IsEnabled = true;
            ButtonCross_Copy6.IsEnabled = true;
            ButtonCross_Copy7.IsEnabled = true;

        }
    }
}
