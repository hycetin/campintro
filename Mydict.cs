using System;
using System.Collections.Generic;
using System.Text;

namespace Mydicthomework
{
    class Mydict<Tkey , Tvalue>
    {
        Tkey[] keys;
        Tvalue[] values; 
        public Mydict()
        {
           keys = new Tkey[0];
            values = new Tvalue[0];
        }
        public void Add(Tkey team , Tvalue player)
        {
            Tkey[] tempKey = keys;
            Tvalue[] tempValue = values;

            keys = new Tkey[keys.Length + 1];
            values = new Tvalue[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }

            keys[keys.Length - 1] = team;
            values[values.Length - 1] = player;

            
            

            

        }
        
        public void Showall()
        {
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine("Team:" + " " + keys[i] + "---> "  + "player: "  + values[i]);

            }
        }



        
       
        


    }
}
