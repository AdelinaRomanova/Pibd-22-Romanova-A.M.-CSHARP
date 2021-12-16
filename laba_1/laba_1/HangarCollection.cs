using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsStormtrooper
{
    class HangarCollection
    {
        readonly Dictionary<string, Hangar<Vehicle>> hangarStages; // Словарь (хранилище) с ангарами
        public List<string> Keys => hangarStages.Keys.ToList(); // Возвращение списка названий ангаров

        private readonly int pictureWidth;
        private readonly int pictureHeight;

        private readonly char separator = ':';
        public HangarCollection(int pictureWidth, int pictureHeight)
        {
            hangarStages = new Dictionary<string, Hangar<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        } // Конструктор
        public void AddParking(string name)
        {
            if (!hangarStages.ContainsKey(name))
            {
                hangarStages.Add(name, new Hangar<Vehicle>(pictureWidth, pictureHeight));
            }
        } // Добавление парковки
        public void DelParking(string name)
        {
            if (hangarStages.ContainsKey(name))
            {
                hangarStages.Remove(name);
            }
        } // Удаление парковки
        public Hangar<Vehicle> this[string ind]
        {
            get
            {
                if (hangarStages.ContainsKey(ind))
                {
                    return hangarStages[ind];
                }
                else
                {
                    return null;
                }
            }
        } // Доступ к парковке

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.Write($"HangarsCollection{Environment.NewLine}");
                foreach (var level in hangarStages)
                {
                    sw.Write($"Hangar{separator}{level.Key}{Environment.NewLine}");
                    ITransport plane = null;
                    for (int i = 0; (plane = level.Value.GetNext(i)) != null; i++)
                    {
                        if (plane != null)
                        {
                            if (plane.GetType().Name == "Warplane")
                            {
                                sw.Write($"Warplane{separator}");
                            }
                            if (plane.GetType().Name == "Stormtrooper")
                            {
                                sw.Write($"Stormtrooper{separator}");
                            }
                            sw.Write(plane + Environment.NewLine);
                        }
                    }
                }
                sw.Close();
            }
        }

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("Файл не существует");

            }
            StreamReader sr = new StreamReader(filename, Encoding.UTF8);

            string line = sr.ReadLine();

            if (line.Contains("HangarsCollection"))
            {
                hangarStages.Clear();
            }
            else
            {
                //если нет такой записи, то это не те данные
                throw new FileFormatException("Неверный формат файла");
            }

            
            string key = string.Empty;

            while ((line = sr.ReadLine()) != null)
            {
                Vehicle plane = null;
                if (line.Contains("Hangar"))
                {
                    key = line.Split(separator)[1];
                    hangarStages.Add(key, new Hangar<Vehicle>(pictureWidth, pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }
         
                if (line.Split(separator)[0] == "Warplane")
                {
                    plane = new Warplane(line.Split(separator)[1]);
                }
                else if (line.Split(separator)[0] == "Stormtrooper")
                {
                    plane = new Stormtrooper(line.Split(separator)[1]);
                }

                var result = hangarStages[key] + plane;
                if (result == -1)
                {
                    throw new TypeLoadException("Не удалось загрузить самолёт в ангар");
                }

            }
        }

    }
}