using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
     class Truck : Vehicle
    {
        protected bool m_Danger;
        protected float m_MaxWeight;
        private string[] m_Keys = { "-danger", "-maxWeight" };

        public Truck(string i_Name, string i_Id, float i_EnergyLevel, List<Tier> i_Tiers, 
                    Engine i_Engine, bool i_Danger, float i_MaxWeight) 
                    : base(i_Name, i_Id, i_Tiers, i_Engine)
        {
            m_Danger = i_Danger;
            m_MaxWeight = i_MaxWeight;
        }

        public Truck(Dictionary<string, string> i_Properties) : base(i_Properties)
        {
            validateKeys(m_Keys, i_Properties);
            m_Danger = Utils.ParseToBool("danger", i_Properties["-danger"]);
            m_MaxWeight = Utils.ParseToFloat("MaxWeight", i_Properties["-maxWeight"]);
        }


        public override string ToString()
        {
            string truckDetails = string.Format("Has Dangerous stuff : {0}\nMax Weight : {1}\n", m_Danger, m_MaxWeight);
            return base.ToString() + truckDetails;
        }
    }
}
