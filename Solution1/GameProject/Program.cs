// See https://aka.ms/new-console-template for more information
using System;
namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 2000,
                FirstName = "Salih",
                LastName = "Sekerci",
                IdentityNumber = 12345
            });
            GameManager gameManager = new GameManager(new GameValidatonManager());
            gameManager.Add(new Game
            {
                Id = 1,
                GameName = "Wow",
                GamePrice=40

            } );
            Console.WriteLine("Hello world");
        }
        }
}