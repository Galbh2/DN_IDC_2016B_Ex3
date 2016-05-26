using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Engine
    {
        protected float m_EnergyLevel;
        protected float m_MaxEnergy;

        public Engine(float i_MaxEnergy, float i_EnergyLevel)
        {
            m_MaxEnergy = i_MaxEnergy;
            m_EnergyLevel = i_EnergyLevel;
        }

        public float getMaxEnergy()
        {
            return m_MaxEnergy;
        }

        public float getEnergyLevel()
        {
            return m_EnergyLevel;
        }

        
    }
}
