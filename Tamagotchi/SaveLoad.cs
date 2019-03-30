using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace Tamagotchi
{
    public class SaveLoad
    {        
        public void Save(Dictionary<string, int> statValues, string name, string gender)
        {
            string filePath = @"..\..\..\Tamagotchi\" + name + ".txt";

            if (File.Exists(filePath))
            {                
                File.Delete(filePath);
            }
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"..\..\..\Tamagotchi\" + name + ".txt"))
            {                                           
                foreach (int statValue in statValues.Values)
                {
                    file.WriteLine(statValue);
                }
                file.WriteLine(gender);
                file.Close();
            }
        }
        public List<dynamic>  Load(string name)
        {
            List<dynamic> values = new List<dynamic>();
            string line;

            using (System.IO.StreamReader file = new System.IO.StreamReader(@"..\..\..\Tamagotchi\" + name + ".txt"))
            {
                int i = 0;      
                while ((line = file.ReadLine()) != null)
                {   if (i == 4)
                    {
                        values.Add(line);
                    }
                    else
                    {
                        values.Add(Convert.ToInt32(line));
                        i += 1;
                    };
                }
                file.Close();
            }
                    
            return values;
        }
    }
}
