using System;

namespace Mydicthomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Mydict<string, string> playerlist = new Mydict<string, string>();
            playerlist.Add("Fenerbahçe" , "Mesut Özil");
            playerlist.Add("Denizlispor" , "Recep Niyaz");
            playerlist.Add("6alatasaray", "Fakkao");

            playerlist.Showall();

        }
    }
}
