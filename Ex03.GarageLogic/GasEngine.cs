using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class GasEngine : Engine
    {
        eGasType m_GasType;

        public GasEngine(float i_MaxEnergy, eGasType i_GasType) : base(i_MaxEnergy)
        {
            m_GasType = i_GasType;
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
