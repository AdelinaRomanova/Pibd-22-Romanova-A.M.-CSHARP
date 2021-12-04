using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsStormtrooper
{
    class HangarCollection
    {
        readonly Dictionary<string, Hangar<Vehicle>> hangarStages; // Словарь (хранилище) с парковками
        public List<string> Keys => hangarStages.Keys.ToList(); // Возвращение списка названий парковок
        private readonly int pictureWidth; 
        private readonly int pictureHeight; 
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

        public Hangar<Vehicle> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < Keys.Count)
                {
                    return hangarStages[Keys[ind]];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
