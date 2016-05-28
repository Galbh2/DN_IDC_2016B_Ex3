using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Utils
    {

        public static bool ValidateKeys(string[] i_Keys, Dictionary<string, string> i_Dict)
        {
            bool hasKey = true;

            foreach (string key in i_Keys)
            {
                if (!i_Dict.ContainsKey(key))
                {
                    return !hasKey;
                }
            }

            return hasKey;
        }

        public static int ParseToInt(string key, string i_Input)
        {
            try
            {
                return int.Parse(i_Input);
            }
            catch (FormatException)
            {

                throw new FormatException(String.Format("Parameter {0} must be an int", key));
            }
        }

        public static float ParseToFloat(string key, string i_Input)
        {
            try
            {
                return float.Parse(i_Input);
            }
            catch (FormatException)
            {

                throw new FormatException(String.Format("Parameter {0} must be a float", key));
            }
        }

        public static bool ParseToBool(string key, string i_Input)
        {
            try
            {
                return bool.Parse(i_Input);
            }
            catch (FormatException)
            {

                throw new FormatException(String.Format("Parameter {0} must be a float", key));
            }
        }


    }
}
