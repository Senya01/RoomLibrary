using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary
{
    public class Room
    {
        double roomLength;
        double roomWidth;

        public double RoomLength
        {
            get { return roomLength; }
            set { roomLength = value; }
        }

        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }

        /// <summary>
        /// Вычисляет периметр комнаты
        /// </summary>
        /// <returns>Значение периметра</returns>
        public double RoomPerimeter()
        {
            return 2 * (roomLength + roomWidth);
        }

        /// <summary>
        /// Вычисляет площадь комнаты
        /// </summary>
        /// <returns>Значение площади</returns>
        public double RoomArea()
        {
            return roomLength * roomWidth;
        }

        /// <summary>
        /// Вычисляет число кв. м.
        /// </summary>
        /// <param name="np">Число человек</param>
        /// <returns>Число кв. м.</returns>
        public double PersonArea(int np)
        {
            return RoomArea() / np;
        }
    }
}
