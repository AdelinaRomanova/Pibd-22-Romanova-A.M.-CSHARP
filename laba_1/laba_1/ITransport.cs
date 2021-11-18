using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsStormtrooper
{
    public interface ITransport
    {
        void SetPosition(int x, int y, int width, int height); // Установка позиции
        void MoveTransport(Direction direction); // Изменение направления пермещения
        void DrawTransport(Graphics g); // Отрисовка
        void SetMainColor(Color color); // Смена основного цвета
    }
}
