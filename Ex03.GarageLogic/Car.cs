using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{   
     class Car : Vehicle
    {
        protected eColor m_Color;
        protected eDoors m_Doors;

        public Car(string i_Name, string i_Id, float i_EnergyLevel, 
                    List<Tier> i_Tiers, Engine i_Engine, eColor i_Color,
                    eDoors i_Doors) 
                    : base(i_Name, i_Id, i_Tiers, i_Engine)
        {
            m_Color = i_Color;
            m_Doors = i_Doors;
        }

        public override string ToString()
        {
            string carDetails = string.Format("Car Color : {0}\nNumber Of Doors : {1}\n", m_Color, m_Doors);
            return base.ToString() + carDetails;
        }
    }



    public enum eColor
    {
        yellow,
        white,
        red,
        black
    }

    public enum eDoors
    {
        two_doors,
        three_doors,
        four_doors,
        five_doors
    }

}
