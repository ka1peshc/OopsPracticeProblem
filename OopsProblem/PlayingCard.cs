using System;
using System.Collections.Generic;
using System.Text;

namespace OopsProblem
{
    public interface IPlayingCard{
        public void shuffle();
    }
    
    class PlayingCard:IPlayingCard
    {
        string[] suit = new string[] { "clubs", "diamond", "spade", "hearts" };
        string[] rank = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        string[,] player1 = new string[9, 2];
        string[,] player2 = new string[9, 2];
        string[,] player3 = new string[9, 2];
        string[,] player4 = new string[9, 2];
        public void shuffle()
        {
            int suitRandom;
            int rankRandom;
            int player;
            Random random = new Random();
            int player1Index = 0, player2Index = 0, player3Index = 0, player4Index = 0;
            for (int i = 0; i < 36; i++)
            {
                suitRandom = random.Next(0, 4);
                rankRandom = random.Next(0, 13);
                player = i % 4;
                switch (player)
                {
                    case 0:
                        player1[player1Index, 0] = suit[suitRandom];
                        player1[player1Index, 1] = rank[rankRandom];
                        player1Index++;
                        break;
                    case 1:
                        player2[player2Index, 0] = suit[suitRandom];
                        player2[player2Index, 1] = rank[rankRandom];
                        player2Index++;
                        break;
                    case 2:
                        player3[player3Index, 0] = suit[suitRandom];
                        player3[player3Index, 1] = rank[rankRandom];
                        player3Index++;
                        break;
                    case 3:
                        player4[player4Index, 0] = suit[suitRandom];
                        player4[player4Index, 1] = rank[rankRandom];
                        player4Index++;
                        break;
                }

            }
        }

        internal void displayPlayersCard()
        {
            Console.WriteLine("Player 1 cards");
            for (int i = 0; i < 9; i++)
            {
                Console.Write("{" + player1[i, 0] + ", " + player1[i, 1] + "}");
            }
            Console.WriteLine("\nPlayer 2 cards");
            for (int i = 0; i < 9; i++)
            {
                Console.Write("{" + player2[i, 0] + ", " + player2[i, 1] + "}");
            }
            Console.WriteLine("\nPlayer 3 cards");
            for (int i = 0; i < 9; i++)
            {
                Console.Write("{" + player3[i, 0] + ", " + player3[i, 1] + "}");
            }
            Console.WriteLine("\nPlayer 4 cards");
            for (int i = 0; i < 9; i++)
            {
                Console.Write("{" + player4[i, 0] + ", " + player4[i, 1] + "}");
            }

        }

        internal void SortingCards()
        {
            Array.Sort(player1);
            Array.Sort(player2);
            Array.Sort(player3);
            Array.Sort(player4);
            displayPlayersCard();
        }
    }
}
