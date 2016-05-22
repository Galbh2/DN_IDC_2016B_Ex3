﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Truck : Vehicle
    {
        bool m_Danger;
        float m_MaxWeight;

        public Truck(string i_Name, string i_Id, float i_EnergyLevel, List<Tier> i_Tiers, 
                    Engine i_Engine, bool i_Danger, float i_MaxWeight) 
                    : base(i_Name, i_Id, i_EnergyLevel, i_Tiers, i_Engine)
        {
            m_Danger = i_Danger;
            m_MaxWeight = i_MaxWeight;
        }
    }
}