using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class GasEngine : Engine
    {
        protected eGasType m_GasType;

        public GasEngine(float i_MaxEnergy, float i_EnergyLevel, eGasType i_GasType) : base(i_MaxEnergy,i_EnergyLevel)
        {
            m_GasType = i_GasType;
        }

        public eGasType getGasType()
        {
            return m_GasType;
        }

        public bool fuel(float i_NumOfLitersToAdd, eGasType i_Gastype)
        {
            bool isAdded = false;
            float newEnergyLevel = i_NumOfLitersToAdd + m_EnergyLevel;
            if (i_Gastype != m_GasType && newEnergyLevel <= m_MaxEnergy)
            {
                m_EnergyLevel = newEnergyLevel;
                isAdded = true;
            }
            return isAdded;
        }
    }

    public enum eGasType
    {
        soler,
        octan_95,
        octan_96,
        octan_98
    }

}
