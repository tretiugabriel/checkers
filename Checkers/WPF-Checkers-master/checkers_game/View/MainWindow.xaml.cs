using checkers_game.Models;
using checkers_game.ViewModels;
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

namespace checkers_game
{
   
    public partial class MainWindow : Window
    {



        Board tabla = new Board();
        Mutare mutare = new Mutare();
        public MainWindow()
        {
            InitializeComponent();
            this.tabla.p1_color = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            this.tabla.p2_color = new SolidColorBrush(Color.FromRgb(0, 0, 255));
            NewGame();

        }

        private void NewGame()
        {
            
            tabla.buttonList = Board.Children.Cast<Button>().ToList();


            tabla.Board_array = new CheckerType[8, 8];

            
            for (int row = 0; row < 8; row++)
            {
                if (row == 0 || row == 2 || row == 6) 
                {

                    for (int col = 0; col < 7; col += 2)
                    { 

                        if (row == 0 || row == 2) { tabla.Board_array[row, col] = CheckerType.Player2_check; } 

                        
                        else { tabla.Board_array[row, col] = CheckerType.Player1_check; }

                    }

                }

                if (row == 1 || row == 5 || row == 7)
                {

                    for (int col = 1; col < 8; col += 2)
                    { 

                        if (row == 5 || row == 7) { tabla.Board_array[row, col] = CheckerType.Player1_check; } 

                        
                        else { tabla.Board_array[row, col] = CheckerType.Player2_check; }

                    }

                }
            } 

            tabla.player_one_turn = true; 
            tabla.players_second_click = false;
            tabla.row = -1;
            tabla.column = 0;
            tabla.prevRow = 0;
            tabla.prevCol = 0;


            tabla.p1_check_count = 12;
            tabla.p2_check_count = 12;


            int counter = 0;

            
            tabla.buttonList.ForEach(button =>

            
            {
                if (counter < 12)
                {
                    button.Content = "●";
                    button.Foreground = tabla.p2_color;
                    counter++;
                }
                else if (counter >= 20 && counter < 32)
                {
                    button.Content = "●";
                    button.Foreground = tabla.p1_color;
                    counter++;
                }
                else
                {
                    button.Content = string.Empty;
                    counter++;
                }   
            }
            );

            mutare.tabla = tabla;
        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            bool x = mutare.cliclEvent(sender, e);
            if(x==false)
            {
                this.Visibility = Visibility.Collapsed;
                this.Close();
                
            }
        }
    }
}