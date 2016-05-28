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

        public void pumpToMax(string i_Id)
        {

        }

        public string doQuery(string v)
        {
            throw new NotImplementedException();
        }

        public void charge(string v1, float v2)
        {
            throw new NotImplementedException();
        }

        public void fuel(string v1, float v2, string v3)
        {
            throw new NotImplementedException();
        }

        public void pump(string v)
        {
            throw new NotImplementedException();
        }

        public void modify(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        public List<string[]> list(eStatus i_Filter)
        {
            List<string[]> results = new List<string[]>();

            foreach (GarageItem item in m_GarageItems)
            {
                if (item.Status == i_Filter)
                {
                    string[] entry = { item.Id, item.Status.ToString()};
                    results.Add(entry);
                }
            }

            return results;
        }

        public List<string[]> list()
        {
            List<string[]> results = new List<string[]>();

            foreach (GarageItem item in m_GarageItems)
            {
                string[] entry = { item.Id, item.Status.ToString() };
                results.Add(entry);
            }

            return results;
        }

        public void add(string i_Id, string i_Type,
                        string i_Owner, string i_Phone,
                        Dictionary<string, string> i_Properties)
        {
            switch (i_Type)
            {
                case ("truck"):
                    m_GarageItems.Add(new GarageItem(
                                      new Truck(i_Properties),
                                      i_Owner,
                                      i_Phone));
                    break;
                default:
                    throw new ArgumentException(
                           string.Format("Cannot add a {0}", i_Type));
            }
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
