using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework
{
    class GameManager : IGameManagerService
    {
        public void BuyGame(Customer customer, Game game)
        {
            Console.WriteLine(customer.FirstName +" " + game.Name + " adlı oyunu satın aldı.");
        }
    }
}
