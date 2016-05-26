using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{

    public class GarageManager
    {
        private readonly int BUFFER_SIZE = 100;
        private List<Vehicle> m_Vehicles;

        public GarageManager()
        {
            m_Vehicles = new List<Vehicle>(BUFFER_SIZE);
        }

        public void addVehicle(string i_Id, eType i_Type)
        {
            //TODO: check about all the different parameters
        }

        public List<string> getVehiclesId()
        {
            return null;
        }

        public List<string> getVehiclesId(eStatus i_Status)
        {
            return null;
        }

        public void changeVehicleStatus(string i_Id, eStatus i_Status)
        {

        }

        public void pumpToMax(string i_Id)
        {

        }

        public bool doQuery(string v)
        {
            throw new NotImplementedException();
        }

        public void charge(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        public void fuel(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        public void pump(string v)
        {
            throw new NotImplementedException();
        }
    }

    public enum eType
    {
        car_gas,
        car_electric,
        bike_gas,
        bike_electric,
        truck
    }

}
