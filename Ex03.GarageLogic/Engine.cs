using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Engine
    {
        float m_EnergyLevel;
        float m_MaxEnergy;

        public Engine(float i_MaxEnergy)
        {
            m_MaxEnergy = i_MaxEnergy;
        }
    }
}
