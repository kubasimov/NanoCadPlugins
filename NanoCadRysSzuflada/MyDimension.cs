using System.Collections.Generic;
using Teigha.DatabaseServices;
using Teigha.Geometry;

namespace NanoCadRysSzuflada
{
    public class MyDimension
    {
        public static List<AlignedDimension> TandemDimension(DataSzuflada dataSzuflada)
        {
            return new List<AlignedDimension>
            {
                new AlignedDimension
                {
                    XLine1Point = new Point3d(dataSzuflada.Startx+dataSzuflada.Grubosc, dataSzuflada.Starty, 0),
                    XLine2Point = new Point3d(dataSzuflada.Startx+dataSzuflada.Szerokosc-dataSzuflada.Grubosc, dataSzuflada.Starty, 0),
                    DimLinePoint = new Point3d(dataSzuflada.Startx,dataSzuflada.Starty-80,0)
                },

                new AlignedDimension
                {
                    XLine1Point = new Point3d(dataSzuflada.Startx, dataSzuflada.Starty, 0),
                    XLine2Point = new Point3d(dataSzuflada.Startx+dataSzuflada.Szerokosc, dataSzuflada.Starty, 0),
                    DimLinePoint = new Point3d(dataSzuflada.Startx,dataSzuflada.Starty-160,0)
                },

                new AlignedDimension
                {
                    XLine1Point = new Point3d(dataSzuflada.Startx + dataSzuflada.Szerokosc, dataSzuflada.Starty, 0),
                    XLine2Point = new Point3d(dataSzuflada.Startx + dataSzuflada.Szerokosc, dataSzuflada.Starty + dataSzuflada.Dlugosc, 0),
                    DimLinePoint = new Point3d(dataSzuflada.Startx+dataSzuflada.Szerokosc+80,dataSzuflada.Starty,0)
                }
            };
        }
    }
}