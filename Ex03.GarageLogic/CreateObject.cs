using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
     class CreateObject
    {
        public  Car createElectricCar()
        {
            List<Tier> sd = new List<Tier>();
            Engine s = new Engine(12, 12);
            eColor haha = eColor.red;
            eDoors asaas = eDoors.five_doors;
            Car a = new Car("asas","sdsd",12,sd,s,haha,asaas);
            return a;
        }
    }
}
