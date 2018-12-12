using System;
using System.Threading;

namespace CourtService
{
    public class Court : ICourt
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public int MakeDecision(ServiceContract serviceContract)
        {
            Random rand = new Random();
            double decision = rand.NextDouble();
            //Thread.Sleep(240000);
            if (decision < 0.48)
            {
                return -1;
            }
            if (decision > 0.48 && decision < 0.52)
            {
                return 1;
            }
            return 0;
        }

    }
}