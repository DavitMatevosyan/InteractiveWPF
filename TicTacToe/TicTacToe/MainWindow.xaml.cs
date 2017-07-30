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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
            StartGame();
        }
        #endregion

        #region Variables

        /// <summary>
        /// List which contains whether the tile is free or used
        /// </summary>
        private TileType[] list;

        /// <summary>
        /// Whether the turn is player 1 or not
        /// </summary>
        private bool player1turn;

        /// <summary>
        /// Whether the game has ended, and a new game should start or not
        /// </summary>
        private bool gameEnded;

        #endregion

        /// <summary>
        /// This method is run when A new game is started
        /// </summary>
        private void StartGame()
        {
            list = new TileType[9];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = TileType.Free;
            }

            Container.Children.Cast<Button>().ToList().ForEach(x =>
            {
                x.Content = string.Empty;
                x.Foreground = Brushes.DarkViolet;
            });

            player1turn = true;
            gameEnded = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (gameEnded)
            {
                StartGame();
                return;
            }

            // Change 'sender' to type of Button
            var button = (Button)sender;

            // Find The Position
            var column = Grid.GetColumn(button);
            var row = Grid.GetRow(button);
            var index = column + (3 * row);

            // Do Nothing if the tile is already NOT free
            if (list[index] != TileType.Free)
                return;

            // When clicked fill the array with relative Types
            list[index] = player1turn ? TileType.X : TileType.O;
            button.Content = player1turn ? "X" : "O";

            // If it is player 2's move, change foreground color
            if (!player1turn)
                button.Foreground = Brushes.Yellow;

            // Toggles player
            player1turn ^= true;

            CheckForWin();
        }

        private void CheckForWin()
        {
            #region Rows

            // Row 0
            if (list[0] != TileType.Free && (list[0] & list[1] & list[2]) == list[0])
            {
                // Game ended
                gameEnded = true;

                // Highlight Winning Tiles
                Button0_0.Foreground = Button1_0.Foreground = Button2_0.Foreground = Brushes.Red;

                // Check Who Won
                CheckWhoWon();
            }

            if (list[3] != TileType.Free && (list[3] & list[4] & list[5]) == list[3])
            {
                // Game ended
                gameEnded = true;

                // Highlight Winning Tiles
                Button0_1.Foreground = Button1_1.Foreground = Button2_1.Foreground = Brushes.Red;

                // Check Who Won
                CheckWhoWon();
            }

            if (list[6] != TileType.Free && (list[6] & list[7] & list[8]) == list[6])
            {
                // Game ended
                gameEnded = true;

                // Highlight Winning Tiles
                Button2_0.Foreground = Button2_1.Foreground = Button2_2.Foreground = Brushes.Red;

                // Check Who Won
                CheckWhoWon();
            }

            #endregion

            #region Columns

            if (list[0] != TileType.Free && (list[0] & list[3] & list[6]) == list[0])
            {
                // Game ended
                gameEnded = true;

                // Highlight Winning Tiles
                Button0_0.Foreground = Button0_1.Foreground = Button0_2.Foreground = Brushes.Red;

                // Check Who Won
                CheckWhoWon();
            }

            if (list[1] != TileType.Free && (list[1] & list[4] & list[7]) == list[1])
            {
                // Game ended
                gameEnded = true;

                // Highlight Winning Tiles
                Button1_0.Foreground = Button1_1.Foreground= Button1_2.Foreground = Brushes.Red;

                // Check Who Won
                CheckWhoWon();
            }

            if (list[2] != TileType.Free && (list[2] & list[5] & list[8]) == list[2])
            {
                // Game ended
                gameEnded = true;

                // Highlight Winning Tiles
                Button2_0.Foreground = Button2_1.Foreground = Button2_2.Foreground = Brushes.Red;

                // Check Who Won
                CheckWhoWon();
            }

            #endregion

            #region Diagonal

            if (list[0] != TileType.Free && (list[0] & list[4] & list[8]) == list[0])
            {
                // Game Ended
                gameEnded = true;

                // Highlight Winning Tiles
                Button0_0.Foreground = Button1_1.Foreground = Button2_2.Foreground = Brushes.Red;

                // Check Who Won
                CheckWhoWon();
            }

            if (list[2] != TileType.Free && (list[2] & list[4] & list[6]) == list[2])
            {
                // Game Ended
                gameEnded = true;

                // Highlight Winning Tiles
                Button0_2.Foreground = Button1_1.Foreground = Button2_0.Foreground = Brushes.Red;

                // Check Who Won
                CheckWhoWon();
            }

            #endregion

            else if (!list.Contains(TileType.Free))
            {
                // If no Available space
                gameEnded = true;

                Container.Children.Cast<Button>().ToList().ForEach(x => x.Foreground = Brushes.Red);
            }

        }

        private void CheckWhoWon()
        {
            MessageBox.Show("Player Won", "Game Ended");
        }
    }

    enum TileType
    {
        /// <summary>
        /// Free Tile
        /// </summary>
        Free,
        /// <summary>
        /// X Tile
        /// </summary>
        X,
        /// <summary>
        /// O Tile
        /// </summary>
        O
    }
}
