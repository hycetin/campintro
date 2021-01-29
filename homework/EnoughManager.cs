using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework
{
    class EnoughManager : IEnoughManager
    {
        public void IsEnough(Customer customer, Game game, Campaign campaign)
        {
            if (customer.EMoneyinWallet == true)
            {
                Console.WriteLine("Oyun alındı");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye.Lütfen hesabınıza para yükleyiniz.");
            }
        }
    }
}
