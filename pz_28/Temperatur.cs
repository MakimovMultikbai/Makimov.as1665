using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Temperatur
    {
     
        public event EventHandler<TemperatureEventArgs> TemperatureChanged;
        public void Start()
        {
            for (int i = -30; i <= 40; i++)
            {
                TemperatureEventArgs args = new TemperatureEventArgs();
                args.Temperature = i;

                OnTemperatureChanged(args);
 
                System.Threading.Thread.Sleep(100);
            }
        }
        protected virtual void OnTemperatureChanged(TemperatureEventArgs e)
        {
            EventHandler<TemperatureEventArgs> handler = TemperatureChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
