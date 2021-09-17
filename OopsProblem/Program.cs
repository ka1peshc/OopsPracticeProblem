using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace OopsProblem
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            PlayingCard pc = new PlayingCard();
            pc.shuffle();
            pc.displayPlayersCard();
            pc.SortingCards();

        }
    }
}