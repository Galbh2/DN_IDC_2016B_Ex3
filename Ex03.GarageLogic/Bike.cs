using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
      class Bike : Vehicle
    {
        protected int m_EngineSize;
        protected eLicenseType m_LicenseType;

        public Bike(string i_Name, string i_Id, float i_EnergyLevel, int i_EngineSize,
                eLicenseType i_LicenseType,List<Tier> i_Tiers, Engine i_Engine) 
                : base(i_Name, i_Id, i_Tiers, i_Engine)
        {
            m_EngineSize = i_EngineSize;
            m_LicenseType = i_LicenseType;
        }

        public override string ToString()
        {
            string bikeDetails = string.Format("Engine Size : {0}\nLicense Type : {1}\n", m_EngineSize, m_LicenseType);
            return base.ToString() + bikeDetails;
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
