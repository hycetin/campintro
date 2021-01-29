//  Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz.
// Bilgi doğrulaması yap.Interface
// Oyun satışı yapılabilecek satış ortamını simule ediniz.Interface
//  Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.
// Satışlarda kampanya entegrasyonunu simule ediniz.Interface

using System;

namespace GameHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game() {Name= "Erzurum",Price= 50,GameType= "Survival" };
            Customer customer1 = new Customer() {CustomerID= 1,FirstName="Jale",LastName="De jale",TCNo="31313169690",EMoneyinWallet=true };
            Campaign campaign = new Campaign() {CampaignName= "Mübarek Cuma",DiscountPrice= 30 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.SignIn(customer1);

            EnoughManager enoughManager = new EnoughManager();
            enoughManager.IsEnough(customer1, game1, campaign);

            CampaingManager campaingManager = new CampaingManager();
            campaingManager.BuywCampaign(game1,customer1,campaign);


            
        }
    }
}
