using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework
{
    class CampaingManager : ICampaignManager
    {
        public void AddCampaign()
        {
            Console.WriteLine("Kampanya eklendi."); 
        }

        public void BuywCampaign(Game game, Customer customer, Campaign campaign)
        {
            Console.WriteLine(customer.FirstName + " "+ game.Name + " adlı oyunu " + campaign.CampaignName +" indirimi ile " + campaign.DiscountPrice + " Tl indirimle aldı." );
        }

        public void Del()
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void Update()
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
