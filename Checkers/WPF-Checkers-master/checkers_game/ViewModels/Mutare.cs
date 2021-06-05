using checkers_game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace checkers_game.ViewModels
{
    class Mutare
    {
        public Board tabla = new Board();
        private bool more_king_jump_available()
        {
            if (tabla.player_one_turn)
            {
                if (tabla.row - 2 >= 0 && tabla.column - 2 >= 0 && tabla.Board_array[tabla.row - 2, tabla.column - 2] == CheckerType.Free && (tabla.Board_array[tabla.row - 1, tabla.column - 1] == CheckerType.Player2_check || tabla.Board_array[tabla.row - 1, tabla.column - 1] == CheckerType.Player2_king))
                {
                    return true;

                }
                else if (tabla.row - 2 >= 0 && tabla.column + 2 <= 7 && tabla.Board_array[tabla.row - 2, tabla.column + 2] == CheckerType.Free && (tabla.Board_array[tabla.row - 1, tabla.column + 1] == CheckerType.Player2_check || tabla.Board_array[tabla.row - 1, tabla.column + 1] == CheckerType.Player2_king))
                {

                    return true;
                }
                else if (tabla.row + 2 <= 7 && tabla.column - 2 >= 0 && tabla.Board_array[tabla.row + 2, tabla.column - 2] == CheckerType.Free && (tabla.Board_array[tabla.row + 1, tabla.column - 1] == CheckerType.Player2_check || tabla.Board_array[tabla.row + 1, tabla.column - 1] == CheckerType.Player2_king))
                {
                    return true;

                }
                else if (tabla.row + 2 <= 7 && tabla.column + 2 <= 7 && tabla.Board_array[tabla.row + 2, tabla.column + 2] == CheckerType.Free && (tabla.Board_array[tabla.row + 1, tabla.column + 1] == CheckerType.Player2_check || tabla.Board_array[tabla.row + 1, tabla.column + 1] == CheckerType.Player2_king))
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (tabla.row - 2 >= 0 && tabla.column - 2 >= 0 && tabla.Board_array[tabla.row - 2, tabla.column - 2] == CheckerType.Free && (tabla.Board_array[tabla.row - 1, tabla.column - 1] == CheckerType.Player1_check || tabla.Board_array[tabla.row - 1, tabla.column - 1] == CheckerType.Player1_king))
                {
                    return true;

                }
                else if (tabla.row - 2 >= 0 && tabla.column + 2 <= 7 && tabla.Board_array[tabla.row - 2, tabla.column + 2] == CheckerType.Free && (tabla.Board_array[tabla.row - 1, tabla.column + 1] == CheckerType.Player1_check || tabla.Board_array[tabla.row - 1, tabla.column + 1] == CheckerType.Player1_king))
                {

                    return true;
                }
                else if (tabla.row - 2 >= 0 && tabla.column - 2 >= 0 && tabla.Board_array[tabla.row + 2, tabla.column - 2] == CheckerType.Free && (tabla.Board_array[tabla.row + 1, tabla.column - 1] == CheckerType.Player1_check || tabla.Board_array[tabla.row + 1, tabla.column - 1] == CheckerType.Player1_king))
                {
                    return true;

                }
                else if (tabla.row - 2 >= 0 && tabla.column + 2 <= 7 && tabla.Board_array[tabla.row + 2, tabla.column + 2] == CheckerType.Free && (tabla.Board_array[tabla.row + 1, tabla.column + 1] == CheckerType.Player1_check || tabla.Board_array[tabla.row + 1, tabla.column + 1] == CheckerType.Player1_king))
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }

        }




        private bool is_normal_king_move()
        {
            if (tabla.Board_array[tabla.row, tabla.column] == CheckerType.Free && (tabla.row - tabla.prevRow == 1 || tabla.row - tabla.prevRow == -1) && (tabla.column - tabla.prevCol == 1 || tabla.column - tabla.prevCol == -1))
            {

                tabla.Board_array[tabla.row, tabla.column] = tabla.Board_array[tabla.prevRow, tabla.prevCol];
                tabla.Board_array[tabla.prevRow, tabla.prevCol] = CheckerType.Free;
                return true;
            }
            else
            {
                return false;
            }
        }


        private bool is_valid_king_jump()
        {
            if (tabla.player_one_turn)
            {
                if (tabla.Board_array[tabla.row, tabla.column] == CheckerType.Free && tabla.row - tabla.prevRow == 2 && tabla.column - tabla.prevCol == 2)
                {
                    if (tabla.Board_array[tabla.row - 1, tabla.column - 1] == CheckerType.Player2_check || tabla.Board_array[tabla.row - 1, tabla.column - 1] == CheckerType.Player2_king)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else if (tabla.Board_array[tabla.row, tabla.column] == CheckerType.Free && tabla.row - tabla.prevRow == 2 && tabla.column - tabla.prevCol == -2)
                {
                    if (tabla.Board_array[tabla.row - 1, tabla.column + 1] == CheckerType.Player2_check || tabla.Board_array[tabla.row - 1, tabla.column + 1] == CheckerType.Player2_king)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else if (tabla.Board_array[tabla.row, tabla.column] == CheckerType.Free && tabla.row - tabla.prevRow == -2 && tabla.column - tabla.prevCol == 2)
                {
                    if (tabla.Board_array[tabla.row + 1, tabla.column - 1] == CheckerType.Player2_check || tabla.Board_array[tabla.row + 1, tabla.column - 1] == CheckerType.Player2_king)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else if (tabla.Board_array[tabla.row, tabla.column] == CheckerType.Free && tabla.row - tabla.prevRow == -2 && tabla.column - tabla.prevCol == -2)
                {
                    if (tabla.Board_array[tabla.row + 1, tabla.column + 1] == CheckerType.Player2_check || tabla.Board_array[tabla.row + 1, tabla.column + 1] == CheckerType.Player2_king)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (tabla.Board_array[tabla.row, tabla.column] == CheckerType.Free && tabla.row - tabla.prevRow == 2 && tabla.column - tabla.prevCol == 2)
                {
                    if (tabla.Board_array[tabla.row - 1, tabla.column - 1] == CheckerType.Player1_check || tabla.Board_array[tabla.row - 1, tabla.column - 1] == CheckerType.Player1_king)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else if (tabla.Board_array[tabla.row, tabla.column] == CheckerType.Free && tabla.row - tabla.prevRow == 2 && tabla.column - tabla.prevCol == -2)
                {
                    if (tabla.Board_array[tabla.row - 1, tabla.column + 1] == CheckerType.Player1_check || tabla.Board_array[tabla.row - 1, tabla.column + 1] == CheckerType.Player1_king)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else if (tabla.Board_array[tabla.row, tabla.column] == CheckerType.Free && tabla.row - tabla.prevRow == -2 && tabla.column - tabla.prevCol == 2)
                {
                    if (tabla.Board_array[tabla.row + 1, tabla.column - 1] == CheckerType.Player1_check || tabla.Board_array[tabla.row + 1, tabla.column - 1] == CheckerType.Player1_king)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else if (tabla.Board_array[tabla.row, tabla.column] == CheckerType.Free && tabla.row - tabla.prevRow == -2 && tabla.column - tabla.prevCol == -2)
                {
                    if (tabla.Board_array[tabla.row + 1, tabla.column + 1] == CheckerType.Player1_check || tabla.Board_array[tabla.row + 1, tabla.column + 1] == CheckerType.Player1_king)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

        }




        private void invalid_choice()
        {
            tabla.players_second_click = false;
            borderChangeBack(tabla.prevButton);
        }
        private bool p2_jump_available()
        {

            if (tabla.row + 2 <= 7 && tabla.column + 2 <= 7 && tabla.Board_array[tabla.row + 2, tabla.column + 2] == CheckerType.Free && (tabla.Board_array[tabla.row + 1, tabla.column + 1] == CheckerType.Player1_check || tabla.Board_array[tabla.row + 1, tabla.column + 1] == CheckerType.Player1_king))
            {
                return true;
            }
            else if (tabla.row + 2 <= 7 && tabla.column - 2 >= 0 && tabla.Board_array[tabla.row + 2, tabla.column - 2] == CheckerType.Free && (tabla.Board_array[tabla.row + 1, tabla.column - 1] == CheckerType.Player1_check || tabla.Board_array[tabla.row + 1, tabla.column - 1] == CheckerType.Player1_king))
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        private bool p1_jump_available()
        {
            if (tabla.row - 2 >= 0 && tabla.column - 2 >= 0 && tabla.Board_array[tabla.row - 2, tabla.column - 2] == CheckerType.Free && (tabla.Board_array[tabla.row - 1, tabla.column - 1] == CheckerType.Player2_check || tabla.Board_array[tabla.row - 1, tabla.column - 1] == CheckerType.Player2_king))
            {
                return true;

            }
            else if (tabla.row - 2 >= 0 && tabla.column + 2 <= 7 && tabla.Board_array[tabla.row - 2, tabla.column + 2] == CheckerType.Free && (tabla.Board_array[tabla.row - 1, tabla.column + 1] == CheckerType.Player2_check || tabla.Board_array[tabla.row - 1, tabla.column + 1] == CheckerType.Player2_king))
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        private void End_turn()
        {
            Is_kinged(); 

            tabla.players_second_click = !tabla.players_second_click;
            tabla.player_one_turn = !tabla.player_one_turn;

            
        }
        private void borderChangeOnCLick(Button button)
        {
            button.BorderThickness = new Thickness(3, 3, 3, 3);
            button.BorderBrush = Brushes.Snow;
        }

        private void borderChangeBack(Button button)
        {

            button.BorderThickness = new Thickness(1, 1, 1, 1);
            button.BorderBrush = Brushes.SlateGray;
        }
        private void updateBoardGui()
        {

            
            tabla.buttonList.ForEach(button =>
            {

                int row = Grid.GetRow(button);
                int col = Grid.GetColumn(button);

                if (tabla.Board_array[row, col] == CheckerType.Player1_check)
                {
                    button.Content = "●";
                    button.Foreground = tabla.p1_color;
                }
                else if (tabla.Board_array[row, col] == CheckerType.Player1_king)
                {
                    button.Content = "✪";
                    button.Foreground = tabla.p1_color;
                }
                else if (tabla.Board_array[row, col] == CheckerType.Player2_check)
                {
                    button.Content = "●";
                    button.Foreground = tabla.p2_color;
                }
                else if (tabla.Board_array[row, col] == CheckerType.Player2_king)
                {
                    button.Content = "✪";
                    button.Foreground = tabla.p2_color;
                }
                else
                {
                    button.Content = "";
                }


            });
        }
        private bool Is_kinged()
        {
            System.Console.WriteLine("is kinged row " + tabla.row);

            if (tabla.row == 0 && tabla.Board_array[tabla.prevRow, tabla.prevCol] == CheckerType.Player1_check)
            {
                System.Console.WriteLine("should be kinged");
                tabla.Board_array[tabla.row, tabla.column] = CheckerType.Player1_king;
                tabla.Board_array[tabla.prevRow, tabla.prevCol] = CheckerType.Free;

                updateBoardGui();
                return true;

            }
            else if (tabla.row == 7 && tabla.Board_array[tabla.prevRow, tabla.prevCol] == CheckerType.Player2_check)
            {
                tabla.Board_array[tabla.row, tabla.column] = CheckerType.Player2_king;
                tabla.Board_array[tabla.prevRow, tabla.prevCol] = CheckerType.Free;

                updateBoardGui();
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool game_over()
        {
            if (tabla.p1_check_count == 0 || tabla.p2_check_count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool cliclEvent(object sender, RoutedEventArgs e)
        {
            if (game_over())
            {
                if (tabla.p1_check_count > 0) 
                {
                    MessageBoxResult result = MessageBox.Show("Joc castigat de ROSU!", "GAME OVER");

                }
                else 
                {
                    MessageBoxResult result = MessageBox.Show("Joc castigat de ALBASTRU!", "GAME OVER");
                }


                return false;
            }





            var button = (Button)sender;




            tabla.column = Grid.GetColumn(button);
            tabla.row = Grid.GetRow(button);




            if (tabla.player_one_turn)
            {
                if (tabla.players_second_click)
                {

                    tabla.prevRow = Grid.GetRow(tabla.prevButton);
                    tabla.prevCol = Grid.GetColumn(tabla.prevButton);
                    if (tabla.Board_array[tabla.prevRow, tabla.prevCol] == CheckerType.Player1_check)
                    {


                        if (tabla.Board_array[tabla.row, tabla.column] == CheckerType.Free && (tabla.row - tabla.prevRow == -1) && (tabla.column - tabla.prevCol == -1 || tabla.column - tabla.prevCol == 1))
                        {

                            if (!Is_kinged())
                            {



                                tabla.Board_array[tabla.row, tabla.column] = CheckerType.Player1_check;
                                tabla.Board_array[tabla.prevRow, tabla.prevCol] = CheckerType.Free;
                                button.Content = "●";
                                button.Foreground = tabla.p1_color;
                                borderChangeBack(tabla.prevButton);
                                tabla.prevButton.Content = "";

                            }

                            End_turn();
                            borderChangeBack(tabla.prevButton);

                        }
                        else if (tabla.Board_array[tabla.row, tabla.column] == CheckerType.Free && (tabla.row - tabla.prevRow == -2) && (tabla.column - tabla.prevCol == -2))
                        {
                            if (tabla.Board_array[tabla.row + 1, tabla.column + 1] == CheckerType.Player2_check || tabla.Board_array[tabla.row + 1, tabla.column + 1] == CheckerType.Player2_king)
                            {
                                tabla.p2_check_count--;


                                tabla.Board_array[tabla.row + 1, tabla.column + 1] = CheckerType.Free;


                                if (Is_kinged())
                                {
                                    End_turn();
                                    borderChangeBack(tabla.prevButton);
                                }
                                else
                                {
                                    tabla.Board_array[tabla.row, tabla.column] = CheckerType.Player1_check;
                                    tabla.Board_array[tabla.prevRow, tabla.prevCol] = CheckerType.Free;


                                    borderChangeBack(tabla.prevButton);
                                    updateBoardGui();


                                    if (p1_jump_available())
                                    {
                                        tabla.prevButton = button;
                                        borderChangeOnCLick(button);

                                    }
                                    else
                                    {

                                        End_turn();
                                        borderChangeBack(tabla.prevButton);
                                    }
                                }

                            }
                        }
                        else if (tabla.Board_array[tabla.row, tabla.column] == CheckerType.Free && (tabla.row - tabla.prevRow == -2) && (tabla.column - tabla.prevCol == 2))
                        {

                            if (tabla.Board_array[tabla.row + 1, tabla.column - 1] == CheckerType.Player2_check || tabla.Board_array[tabla.row + 1, tabla.column - 1] == CheckerType.Player2_king)
                            {
                                tabla.p2_check_count--;

                                tabla.Board_array[tabla.row + 1, tabla.column - 1] = CheckerType.Free;

                                if (Is_kinged())
                                {

                                    End_turn();
                                    borderChangeBack(tabla.prevButton);
                                }
                                else
                                {
                                    tabla.Board_array[tabla.row, tabla.column] = CheckerType.Player1_check;
                                    tabla.Board_array[tabla.prevRow, tabla.prevCol] = CheckerType.Free;



                                    borderChangeBack(tabla.prevButton);
                                    updateBoardGui();

                                    if (p1_jump_available())
                                    {
                                        tabla.prevButton = button;
                                        borderChangeOnCLick(button);

                                    }
                                    else
                                    {
                                        End_turn();
                                        borderChangeBack(tabla.prevButton);
                                    }
                                }


                            }

                        }
                        else
                        {
                            invalid_choice();
                        }
                    }
                    else
                    {
                        if (is_normal_king_move())
                        {
                            button.Content = "✪";
                            button.Foreground = tabla.p1_color;

                            tabla.prevButton.Content = "";

                            borderChangeBack(tabla.prevButton);

                            End_turn();

                        }
                        else if (is_valid_king_jump())
                        {
                            tabla.p2_check_count--;
                            int jumped_row = (int)(tabla.row + ((tabla.row - tabla.prevRow) * -.5));
                            int jumped_col = (int)(tabla.column + ((tabla.column - tabla.prevCol) * -.5));


                            tabla.Board_array[tabla.row, tabla.column] = CheckerType.Player1_king;

                            System.Console.WriteLine("value of jumped piece " + (jumped_row) + "  " + (jumped_col));
                            tabla.Board_array[jumped_row, jumped_col] = CheckerType.Free;

                            tabla.Board_array[tabla.prevRow, tabla.prevCol] = CheckerType.Free;

                            borderChangeBack(tabla.prevButton);
                            updateBoardGui();

                            if (more_king_jump_available())
                            {
                                tabla.prevButton = button;
                                borderChangeOnCLick(button);

                            }
                            else
                            {

                                End_turn();
                                borderChangeBack(tabla.prevButton);
                            }
                        }
                        else
                        {
                            invalid_choice();
                        }

                    }



                }

                else
                {


                    if (tabla.Board_array[tabla.row, tabla.column] == CheckerType.Player1_check || tabla.Board_array[tabla.row, tabla.column] == CheckerType.Player1_king)
                    {
                        tabla.prevButton = button;
                        borderChangeOnCLick(button);
                        tabla.players_second_click = true;
                    }


                }
            }
            else
            {



                if (tabla.players_second_click)
                {
                    tabla.prevRow = Grid.GetRow(tabla.prevButton);
                    tabla.prevCol = Grid.GetColumn(tabla.prevButton);
                    if (tabla.Board_array[tabla.prevRow, tabla.prevCol] == CheckerType.Player2_check)
                    {
                        if (tabla.Board_array[tabla.row, tabla.column] == CheckerType.Free && (tabla.row - tabla.prevRow == 1) && (tabla.column - tabla.prevCol == -1 || tabla.column - tabla.prevCol == 1))
                        {
                            if (!Is_kinged())
                            {
                                tabla.Board_array[tabla.row, tabla.column] = CheckerType.Player2_check;

                                tabla.Board_array[tabla.prevRow, tabla.prevCol] = CheckerType.Free;

                                button.Content = "●";
                                button.Foreground = tabla.p2_color;
                                borderChangeBack(tabla.prevButton);
                                tabla.prevButton.Content = "";
                            }


                            End_turn();
                            borderChangeBack(tabla.prevButton);
                        }
                        else if (tabla.Board_array[tabla.row, tabla.column] == CheckerType.Free && (tabla.row - tabla.prevRow == 2) && tabla.column - tabla.prevCol == -2)
                        {

                            if (tabla.Board_array[tabla.row - 1, tabla.column + 1] == CheckerType.Player1_check || tabla.Board_array[tabla.row - 1, tabla.column + 1] == CheckerType.Player1_king)
                            {
                                tabla.p1_check_count--;

                                tabla.Board_array[tabla.row - 1, tabla.column + 1] = CheckerType.Free;


                                if (Is_kinged())
                                {
                                    End_turn();
                                    borderChangeBack(tabla.prevButton);
                                }
                                else
                                {

                                    tabla.Board_array[tabla.row, tabla.column] = CheckerType.Player2_check;
                                    tabla.Board_array[tabla.prevRow, tabla.prevCol] = CheckerType.Free;


                                    borderChangeBack(tabla.prevButton);
                                    updateBoardGui();

                                    if (p2_jump_available())
                                    {
                                        borderChangeOnCLick(button);
                                        tabla.prevButton = button;
                                    }
                                    else
                                    {
                                        End_turn();
                                        borderChangeBack(tabla.prevButton);
                                    }
                                }
                            }
                        }
                        else if (tabla.Board_array[tabla.row, tabla.column] == CheckerType.Free && (tabla.row - tabla.prevRow == 2) && tabla.column - tabla.prevCol == 2)
                        {

                            tabla.p1_check_count--;
                            tabla.Board_array[tabla.row - 1, tabla.column - 1] = CheckerType.Free;


                            if (Is_kinged())
                            {
                                End_turn();
                                borderChangeBack(tabla.prevButton);
                            }
                            else
                            {


                                tabla.Board_array[tabla.row, tabla.column] = CheckerType.Player2_check;
                                tabla.Board_array[tabla.prevRow, tabla.prevCol] = CheckerType.Free;

                                borderChangeBack(tabla.prevButton);
                                updateBoardGui();

                                if (p2_jump_available())
                                {
                                    borderChangeOnCLick(button);
                                    tabla.prevButton = button;
                                }
                                else
                                {
                                    End_turn();
                                    borderChangeBack(tabla.prevButton);
                                }
                            }

                        }
                        else
                        {

                            invalid_choice();
                        }
                    }
                    else
                    {

                        if (is_normal_king_move())
                        {
                            button.Content = "✪";
                            button.Foreground = tabla.p2_color;

                            tabla.prevButton.Content = "";

                            borderChangeBack(tabla.prevButton);

                            End_turn();

                        }
                        else if (is_valid_king_jump())
                        {
                            tabla.p1_check_count--;

                            int jumped_row = (int)(tabla.row + ((tabla.row - tabla.prevRow) * -.5));
                            int jumped_col = (int)(tabla.column + ((tabla.column - tabla.prevCol) * -.5));


                            tabla.Board_array[tabla.row, tabla.column] = CheckerType.Player2_king;

                            System.Console.WriteLine("value of jumped piece " + (tabla.row + jumped_row) + "  " + (tabla.column + jumped_col));
                            tabla.Board_array[jumped_row, jumped_col] = CheckerType.Free;

                            tabla.Board_array[tabla.prevRow, tabla.prevCol] = CheckerType.Free;

                            borderChangeBack(tabla.prevButton);
                            updateBoardGui();


                            if (more_king_jump_available())
                            {
                                tabla.prevButton = button;
                                borderChangeOnCLick(button);

                            }
                            else
                            {

                                End_turn();
                                borderChangeBack(tabla.prevButton);
                            }
                        }
                        else
                        {
                            invalid_choice();
                        }
                    }
                }
                else
                {
                    

                    if (tabla.Board_array[tabla.row, tabla.column] == CheckerType.Player2_check || tabla.Board_array[tabla.row, tabla.column] == CheckerType.Player2_king)
                    {
                        tabla.prevButton = button;
                        tabla.players_second_click = true;
                        borderChangeOnCLick(button);
                    }
                }


            }
            return true;
        }


    }
}
