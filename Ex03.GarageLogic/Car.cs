using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{   
    class Car : Vehicle
    {
        eColor m_Color;
        eDoors m_Doors;

        public Car(string i_Name, string i_Id, float i_EnergyLevel, 
                    List<Tier> i_Tiers, Engine i_Engine, eColor i_Color,
                    eDoors i_Doors) 
                    : base(i_Name, i_Id, i_EnergyLevel, i_Tiers, i_Engine)
        {
            m_Color = i_Color;
            m_Doors = i_Doors;
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
