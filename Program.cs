//open View -> Terminal to run the game

using System;

namespace Myfirstprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string[] words = {"tiger", "lion", "cheetah", "bobcat", "leopard"}; 
            string wordToGuess = words[rand.Next(0, words.Length)]; 

            bool hasWon = false;

            for(int i = 0; i < words.Length/2; i++ )
                {
                    Console.WriteLine("Guess the word: "); 

                    for(int j = 0; j < words.Length; j++)
                    {
                        Console.WriteLine(words[j] + " "); 
                    }

                    Console.WriteLine();

                    string guess = Console.ReadLine(); 

                    if(guess == wordToGuess)
                    {
                        hasWon = true;
                        break; 
                    }
                }

                if(hasWon)
                {
                    Console.WriteLine("Congratulations, you won!");
                }

                else{
                    Console.WriteLine("Sorry, you lose! The word was " + wordToGuess);
                }
        }
    }
}
