using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Bike : Vehicle
    {
        int m_EngineSize;
        eLicenseType m_LicenseType;

        public Bike(string i_Name, string i_Id, float i_EnergyLevel, int i_EngineSize,
                eLicenseType i_LicenseType,List<Tier> i_Tiers, Engine i_Engine) 
                : base(i_Name, i_Id, i_EnergyLevel, i_Tiers, i_Engine)
        {
            m_EngineSize = i_EngineSize;
            m_LicenseType = i_LicenseType;
        }
    }
    
    public enum eLicenseType
    {
        A,
        A1,
        AB,
        B1
    }
}
