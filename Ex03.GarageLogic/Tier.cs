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
        
        public bool Pump(float i_AddToAirpressure)
        {
           float newAirPressure = m_Airpressure + i_AddToAirpressure;
            bool isAdded = false;
            if(newAirPressure <= m_MaxAirPressure)
            {
                m_Airpressure = newAirPressure;
                isAdded = true;
            }
            return isAdded;

        }

        public override string ToString()
        {
            return string.Format("Manufacturer : {0}\nMax Airpressure : {1}\nCurrent Airpressure : {2}", m_Manufactor, m_MaxAirPressure, m_Airpressure);
        }

    }
}
