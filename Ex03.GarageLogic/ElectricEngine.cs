using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class ElectricEngine : Engine
    {
        public ElectricEngine(float i_MaxEnergy,float i_EnergyLevel) : base(i_MaxEnergy,i_EnergyLevel)
        {

        }

        public bool chargeTheEngine(float i_numOfHouersToAdd)
        {
            bool isAdded = false;
            float newEnergyLevel = i_numOfHouersToAdd + m_EnergyLevel;
            if(newEnergyLevel <= m_MaxEnergy)
            {
                m_EnergyLevel = newEnergyLevel;
                isAdded = true;
            }
            return isAdded;

        }


        public override string ToString()
        {
            return string.Format("Max Energy : {1}\nCurrent Energy : {2}\n", m_MaxEnergy, m_EnergyLevel);
        }



    }
}
