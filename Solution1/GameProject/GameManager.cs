using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GameManager : IGameService

     
    {
        IGameValidationService _GameValidationService;

        public GameManager(IGameValidationService gameValidationService)
        {
            _GameValidationService = gameValidationService;
        }

        public void Add(Game game)
        {
            if (_GameValidationService.Validate(game))
            {
                Console.WriteLine("Oyun eklendi");
            }
            else
            {
                Console.WriteLine("Oyun bulunamadı");
            }
        }

      

        public void Delete(Game game)
        {
            if (_GameValidationService.Validate(game))
            {   
                Console.WriteLine("Oyun silindi");
            }
            else
            {
                Console.WriteLine("Oyun bulunamadı");
            }
        }

    

        public void Update(Game game)
        {
            if (_GameValidationService.Validate(game))
            {
                Console.WriteLine("Oyun güncellendi");
            }
            else
            {
                Console.WriteLine("Oyun bulunamadı");
            }
        }

        
    }
}
