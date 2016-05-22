using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Tier
    {
        private string m_Manufactor;
        private float m_Airpressure;
        private float m_MaxAirPressure;

        public Tier(string i_Manufactor, float i_Airpressure, float i_MaxAirPressure)
        {
            m_Manufactor = i_Manufactor;
            m_Airpressure = i_Airpressure;
            m_MaxAirPressure = i_MaxAirPressure;
        }

        public void Pump()
        {

        }
        
    }
}
