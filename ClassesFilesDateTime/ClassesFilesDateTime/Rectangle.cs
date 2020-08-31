using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesFilesDateTime
{
    public class Rectangle
    {
        public int width { get; set; }
        public int height { get; set; }
        public DateTime creationDate { get; set; }


        /// <summary>
        /// this is the default / empty constructor
        /// </summary>
        public Rectangle()
        {
            width = 0;
            height = 0;
            creationDate = DateTime.Now;
        }

        /// <summary>
        /// overloaded constructor for the rectangle class
        /// </summary>
        /// <param name="width"></param> an integer representing width
        /// <param name="height"></param> an integer representing height
        public Rectangle(int width, int height) : this()
        {
            this.width = width;
            this.height = height;
            //creationDate = DateTime.Now;
        }

        /// <summary>
        /// calculate area of the Rectangle
        /// </summary>
        /// <returns> the area of the Rectangle </returns>
        public double area()
        {
            return width * height;
        }

        public override string ToString()
        {
            var diff = DateTime.Now - creationDate;
            string output = $"The rectange was created on {creationDate.DayOfWeek} {diff.TotalSeconds} seconds ago and has a width of {width} and height of {height}" +
                            $"\n\t The area of the rectangle is {area()}";
            
            return output;
        }
    }
}
