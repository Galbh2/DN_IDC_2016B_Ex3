using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
     class GarageItem
    {
        private Vehicle m_Vehicle;
        private string m_OwnerName;
        private string m_OwnerPhone;
        private eStatus m_Status = eStatus.maintenance;

        public GarageItem(Vehicle i_Vehicle,string i_OwnerName, string i_OwnerPhone)
        {
            m_Vehicle = i_Vehicle;
            m_OwnerName = i_OwnerName;
            m_OwnerPhone = i_OwnerPhone;
 
        }

        public string Id{
            get
            {
                return m_Vehicle.Id;
            }
        }

        public eStatus Status
        {
            get
            {
                return m_Status;
            }
            set
            {
                m_Status = value;
            }
        }


    }

    public enum eStatus
    {
        maintenance, 
        ready,
        paid
    }
}
