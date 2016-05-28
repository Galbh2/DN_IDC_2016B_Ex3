﻿using System;
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

        

        public Vehicle(string i_Name, string i_Id,
                        List<Tier> i_Tiers, Engine i_Engine)
        {
            m_Name = i_Name;
            m_Id = i_Id;
            m_Tiers = i_Tiers;
            m_Engine = i_Engine;
        }

        public Vehicle(Dictionary<string, string> i_Properties)
        {
            string[] keys = { "-name",
                               "-id",
                            };

            if (!Utils.ValidateKeys(keys, i_Properties))
            {
                throw new Exception();
                //TODO: write custom exceptiom for a missing key
            }

            m_Id = i_Properties["-id"];
            m_Name = i_Properties["-name"];

        }

        public string Id
        {
            get 
            {
                return m_Id;
            }
        }

        public override string ToString()
        {
    
            return string.Format("Id : {0}\nName : {1}\nTiers Details : {2}\nEngine Details : \n{2}", m_Id, m_Name,m_Tiers.ToString(),m_Engine.ToString());
        }
    }

    
}
