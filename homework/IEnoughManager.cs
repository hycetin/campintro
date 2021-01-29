using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework
{
    interface IEnoughManager
    {
        void IsEnough(Customer customer,Game game,Campaign campaign);
    }
}
