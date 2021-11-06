using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    class ParkingCollection
    {
        readonly Dictionary<string, Parking<Vehicle>> parkingStages; // Словарь (хранилище) с парковками
        public List<string> Keys => parkingStages.Keys.ToList(); // Возвращение списка названий парковок
        private readonly int pictureWidth; // Ширина окна отрисовки
        private readonly int pictureHeight; // Высота окна отрисовки
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        } // Конструктор
        public void AddParking(string name)
        {
            if (!parkingStages.ContainsKey(name))
            {
                parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
            }
        } // Добавление парковки
        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        } // Удаление парковки
        public Parking<Vehicle> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                else
                {
                    return null;
                }
            }
        } // Доступ к парковке

        public Parking<Vehicle> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < Keys.Count)
                {
                    return parkingStages[Keys[ind]];
                }
                else
                {
                    return null;
                }
            }
        }

    }
}
