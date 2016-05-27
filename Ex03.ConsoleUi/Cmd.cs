using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Ex03.GarageLogic;


namespace Ex03.ConsoleUi
{
    class Cmd
    {
        private string m_UnknownVerbMsg = "Unknown verb, enter help for more information";
        private string m_MissingKeyMsg = "Missing parameter {0}";
        private string m_HelloMsg = "Welcome! Enter one command per line";

        private GarageManager manager;
      

        public static void Main()
        {
            Cmd cmd = new Cmd();
            cmd.Start();
        }

        public void Start()
        {
            manager = new GarageManager();
            wl(m_HelloMsg);
            string input;
            while (!(input = System.Console.ReadLine()).Equals("Q"))
            {
                run(parse(input));
            }
        }

        public Dictionary<string, string > parse(String i_Input)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            i_Input = Regex.Replace(i_Input, @"\s+", " ");
            string[] input = i_Input.Split(' ');

            dict.Add("verb", input[0]);

            if (input.Length > 2)
            {
                for (int i = 1; i < input.Length; i += 2)
                {
                    dict.Add(input[i], input[i + 1]);
                    // TODO: check for duplicates
                }
            }

            foreach (KeyValuePair<string, string> entry in dict)
            {
                System.Console.WriteLine(String.Format("{0}, {1}", entry.Key, entry.Value));
            }

            return dict;
        }

        private void run(Dictionary<string, string> i_Dict)
        {
            if (i_Dict.ContainsKey("verb"))
            {
                switch (i_Dict["verb"])
                {
                    case "add":
                        add(i_Dict);
                        break;
                    case "list":
                        printList(i_Dict);
                        break;
                    case "modify":
                        modify(i_Dict);
                        break;
                    case "pump":
                        pump(i_Dict);
                        break;
                    case "fuel":
                        fuel(i_Dict);
                        break;
                    case "charge":
                        charge(i_Dict);
                        break;
                    case "query":
                        doQuery(i_Dict);
                        break;
                    default:
                        System.Console.WriteLine(m_UnknownVerbMsg);
                        break;
                }
            }
        }

        private void doQuery(Dictionary<string, string> i_Dict)
        {
            string[] keys = { "-id" };
            if (!validateKeys(keys, i_Dict))
            {
                return;
            }

            try
            {
                wl(manager.doQuery
                    (parseToInt("id", i_Dict["-id"])));
            }
            catch (Exception e)
            {
                wl(e.Message);
            }
        }

        private void charge(Dictionary<string, string> i_Dict)
        {
            string[] keys = { "-id", "-minutes" };
            if (!validateKeys(keys, i_Dict))
            {
                return;
            }

            try
            {
                manager.charge(parseToInt("id", i_Dict["-id"]),
                               parseToFloat("minutes", i_Dict["-minutes"]));
            }
            catch (Exception e)
            {
                wl(e.Message); 
            }
        }

        private void fuel(Dictionary<string, string> i_Dict)
        {
            string[] keys = { "-id", "-amount", "-ftype" };
            if (!validateKeys(keys, i_Dict))
            {
                return;
            }

            try
            {
                manager.fuel(parseToInt("id", i_Dict["-id"]), 
                            parseToFloat("amount", i_Dict["-amount"]), 
                            i_Dict["-ftype"]);
            }
            catch (Exception e)
            {
                wl(e.Message);
            }
        }

        private void pump(Dictionary<string, string> i_Dict)
        {
            string[] keys = { "-id"};
            if (!validateKeys(keys, i_Dict))
            {
                return;
            }

            try
            {
                manager.pump(parseToInt("id", i_Dict["-id"]));
            }
            catch (Exception e)
            {
                wl(e.Message);
            }
        }

        private void modify(Dictionary<string, string> i_Dict)
        {
            string[] keys = { "-id", "-status" };
            if (!validateKeys(keys, i_Dict))
            {
                return;
            }

            try
            {
                manager.modify(parseToInt("id", i_Dict["-id"]),
                                i_Dict["-status"]);
            }
            catch (Exception e)
            {
                wl(e.Message);
            }
        }

        private void printList(Dictionary<string, string> i_Dict)
        {

            string filter;
            bool doFilter = i_Dict.TryGetValue("-filter", out filter);

            try
            {
                manager.list(parseToInt("id", i_Dict["-id"]), doFilter);
            }
            catch (Exception e)
            {
                wl(e.Message);
            }
        }

        private void add(Dictionary<string, string> i_Dict)
        {
            string[] keys = { "-id", "-type" };
            if (!validateKeys(keys, i_Dict))
            {
                return;
            }

            try
            {
                manager.add(parseToInt("-id", i_Dict["id"]),
                    i_Dict["-type"]);
            }
            catch (Exception e)
            {
                wl(e.Message);
            }
        }

        private bool validateKeys(string[] i_Keys, Dictionary<string,string> i_Dict)
        {
            bool hasKey = true;

            foreach (string key in i_Keys)
            {
                if (!i_Dict.ContainsKey(key))
                {
                    System.Console.WriteLine(string.Format(m_MissingKeyMsg, key));
                    return !hasKey;
                }
            }

            return hasKey;
        }

        private int parseToInt(string key, string i_Input)
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

        private float parseToFloat(string key, string i_Input)
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

        private void wl (string i_Input)
        {
            System.Console.WriteLine(i_Input);
        }
    }
}
