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

        private GarageManager manager;
      

        public static void Main()
        {
            System.Console.WriteLine("Enter Command...");
            String input = System.Console.ReadLine();
            Cmd cmd = new Cmd();
            cmd.parse(input);
            System.Console.ReadLine();
        }

        public Dictionary<string, string > parse(String i_Input)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            i_Input = Regex.Replace(i_Input, @"\s+", " ");
            string[] input = i_Input.Split(' ');

            dict.Add("verb", input[0]);

            for (int i = 1; i < input.Length; i += 2)
            {
                dict.Add(input[i], input[i + 1]);
                // TODO: check for duplicates
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
                System.Console.WriteLine(manager.doQuery(i_Dict["-id"]));
            }
            catch (Exception)
            {
                throw;
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
                manager.charge(i_Dict["-id"], i_Dict["-minutes"]);
            }
            catch (Exception)
            {
                throw;
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
                manager.fuel(i_Dict["-id"], i_Dict["-amount"], i_Dict["-ftype"]);
            }
            catch (Exception)
            {
                throw;
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
                manager.pump(i_Dict["-id"]);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void modify(Dictionary<string, string> i_Dict)
        {
            throw new NotImplementedException();
        }

        private void printList(Dictionary<string, string> i_Dict)
        {
            throw new NotImplementedException();
        }

        private void add(Dictionary<string, string> i_Dict)
        {
            string[] keys = { "-type" };
            // pass a dict to garage manager
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
    }
}
