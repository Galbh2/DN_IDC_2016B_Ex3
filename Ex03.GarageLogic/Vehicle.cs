using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Vehicle
    {
        protected string m_Name;
        protected string m_Id;
        protected float m_EnergyLevelInPercents;
        protected List<Tier> m_Tiers;
        protected Engine m_Engine;
        protected eStatus m_Status;

        public Vehicle(string i_Name, string i_Id,
                        List<Tier> i_Tiers, Engine i_Engine)
        {
            m_Name = i_Name;
            m_Id = i_Id;
            m_Tiers = i_Tiers;
            m_Engine = i_Engine;
        }
    }

    public enum eStatus
    {
        ready,
        not_ready
    }
}
