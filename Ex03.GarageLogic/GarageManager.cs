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
        private List<GarageItem> m_GarageItems;

        public GarageManager()
        {
            m_GarageItems = new List<GarageItem>(BUFFER_SIZE);
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

        public string doQuery(int v)
        {
            throw new NotImplementedException();
        }

        public void charge(int v1, float v2)
        {
            throw new NotImplementedException();
        }

        public void fuel(int v1, float v2, string v3)
        {
            throw new NotImplementedException();
        }

        public void pump(int v)
        {
            throw new NotImplementedException();
        }

        public void modify(int v1, string v2)
        {
            throw new NotImplementedException();
        }

        public void list(int v, bool doFilter)
        {
            throw new NotImplementedException();
        }

        public void add(int i_Id, string v)
        {
            System.Console.WriteLine(v);
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
