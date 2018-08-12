using System.Collections.Generic;
using Teigha.DatabaseServices;
using Teigha.Geometry;

namespace NanoCadRysSzuflada
{
    public class MyRectangle
    {
        private static Polyline Get(double startx, double starty, int szerokosc, int wysokosc)
        {
            var acPoly = new Polyline();
            acPoly.SetDatabaseDefaults();
            acPoly.AddVertexAt(0, new Point2d(startx, starty), 0, 0, 0);
            acPoly.AddVertexAt(1, new Point2d(startx + szerokosc, starty), 0, 0, 0);
            acPoly.AddVertexAt(2, new Point2d(startx + szerokosc, starty + wysokosc), 0, 0, 0);
            acPoly.AddVertexAt(3, new Point2d(startx, starty + wysokosc), 0, 0, 0);
            acPoly.Closed = true;

            return acPoly;
        }

        public static List<Polyline> TandemRectangle(DataSzuflada dataSzuflada)
        {
            return new List<Polyline>
            {
                Get(dataSzuflada.Startx, dataSzuflada.Starty,dataSzuflada.Grubosc, dataSzuflada.Dlugosc),
                Get(dataSzuflada.Startx+dataSzuflada.Grubosc, dataSzuflada.Starty, dataSzuflada.Szerokosc-(2*dataSzuflada.Grubosc), dataSzuflada.Grubosc ),
                Get(dataSzuflada.Startx+dataSzuflada.Grubosc,dataSzuflada.Starty+dataSzuflada.Dlugosc-dataSzuflada.Grubosc,dataSzuflada.Szerokosc-(2*dataSzuflada.Grubosc),dataSzuflada.Grubosc),
                Get(dataSzuflada.Startx+dataSzuflada.Szerokosc-dataSzuflada.Grubosc,dataSzuflada.Starty,dataSzuflada.Grubosc, dataSzuflada.Dlugosc)
            };
        }
    }
}