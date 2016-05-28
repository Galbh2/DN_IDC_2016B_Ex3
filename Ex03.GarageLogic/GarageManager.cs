using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{

    public class GarageManager
    {
        
        private Dictionary<string, GarageItem> m_GarageItems;

        public GarageManager()
        {
            m_GarageItems = new Dictionary<string, GarageItem>();
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

        public void modify(string i_Id, eStatus i_Status)
        {
            GarageItem item = getById(i_Id);
           
            if (item == null)
            {
                throw new ArgumentException("Entry was not found...");
            } else
            {
                item.Status = i_Status; 
            }
        }

        public List<string[]> list(eStatus i_Filter)
        {
            List<string[]> results = new List<string[]>();

            foreach (KeyValuePair<string, GarageItem> item in m_GarageItems)
            {
                if (item.Value.Status == i_Filter)
                {
                    string[] entry = { item.Value.Id, item.Value.Status.ToString()};
                    results.Add(entry);
                }
            }

            return results;
        }

        public List<string[]> list()
        {
            List<string[]> results = new List<string[]>();

            foreach (KeyValuePair<string, GarageItem> item in m_GarageItems)
            {
                string[] entry = { item.Value.Id, item.Value.Status.ToString() };
                results.Add(entry);
            }

            return results;
        }

        public bool add(string i_Id, string i_Type,
                string i_Owner, string i_Phone,
                Dictionary<string, string> i_Properties)
        {
            GarageItem item = getById(i_Id);
            bool exist = true;
            if (item == null)
            {
                // create a new entry
                _add(i_Id, i_Type, i_Owner, i_Phone, i_Properties);
                return !exist;
            }
            else
            {
                // put in mainteinance

                item.Status = eStatus.maintenance;
                return exist;
            }
        }

        public void _add(string i_Id, string i_Type,
                        string i_Owner, string i_Phone,
                        Dictionary<string, string> i_Properties)
        {
            switch (i_Type)
            {
                case ("truck"):
                    m_GarageItems.Add(i_Id, new GarageItem(
                                      new Truck(i_Properties),
                                      i_Owner,
                                      i_Phone));
                    break;
                default:
                    throw new ArgumentException(
                           string.Format("Cannot add a {0}", i_Type));
            }
        }

        private GarageItem getById(string i_Id)
        {
            GarageItem item;
            m_GarageItems.TryGetValue(i_Id, out item);
            return item;
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
