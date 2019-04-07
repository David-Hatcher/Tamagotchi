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

        public void Save(dynamic tama)
        {
            using (var context = new TamagotchiEntities())
            {
                var Tama = context.TamagotchiObjects.Find(tama.Name);
                if (Tama != null)
                {
                    Tama.Happiness = tama.Happiness;
                    Tama.Fullness = tama.Fullness;
                    Tama.Tiredness = tama.Tiredness;
                    Tama.Hunger = tama.Hunger;
                }
                else
                {
                    context.TamagotchiObjects.Add(tama);
                }
                context.SaveChanges();
            }
            //string filePath = @"..\..\..\Tamagotchi\" + name + ".txt";

            //if (File.Exists(filePath))
            //{                
            //    File.Delete(filePath);
            //}
            //using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"..\..\..\Tamagotchi\" + name + ".txt"))
            //{                                           
            //    foreach (int statValue in statValues.Values)
            //    {
            //        file.WriteLine(statValue);
            //    }
            //    file.WriteLine(gender);
            //    file.Close();
            //}
        }
        public dynamic Load(string name)
        {

            var context = new TamagotchiEntities();
            var tama = context.TamagotchiObjects.Find(name);
            int[] stats = { tama.Happiness - 50, tama.Hunger - 50, tama.Tiredness - 50, tama.Fullness - 50 };
            tama.adjustStats(stats);
            return tama;
        }
            //List<dynamic> values = new List<dynamic>();
            //string line;

            //using (System.IO.StreamReader file = new System.IO.StreamReader(@"..\..\..\Tamagotchi\" + name + ".txt"))
            //{
            //    int i = 0;      
            //    while ((line = file.ReadLine()) != null)
            //    {   if (i == 4)
            //        {
            //            values.Add(line);
            //        }
            //        else
            //        {
            //            values.Add(Convert.ToInt32(line));
            //            i += 1;
            //        };
            //    }
            //    file.Close();
            //}

            //return values;
    }
}
