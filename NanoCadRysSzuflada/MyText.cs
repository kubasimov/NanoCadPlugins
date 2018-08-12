using System.Collections.Generic;
using Teigha.DatabaseServices;
using Teigha.Geometry;

namespace NanoCadRysSzuflada
{
    public class MyText
    {
        public static List<MText> TandemText(DataSzuflada dataSzuflada)
        {
            var acMText = new MText();
            acMText.SetDatabaseDefaults();
            acMText.Location = new Point3d(dataSzuflada.Startx + dataSzuflada.Szerokosc + 200, dataSzuflada.Starty + dataSzuflada.Dlugosc, 0);
            acMText.Width = 800;

            if (dataSzuflada.Spod)
            {
                acMText.Contents = "Elementy szuflady\n" +
                                   dataSzuflada.Numer + "sz  " + (dataSzuflada.Dlugosc) + "  " + (dataSzuflada.Wysokosc - 40) + "  " + dataSzuflada.Ilosc * 2 + "\n" +
                                   (dataSzuflada.Numer + 1) + "sz  " + (dataSzuflada.Szerokosc - (dataSzuflada.Grubosc * 2)) + "  " + (dataSzuflada.Wysokosc - 40 - 12 - dataSzuflada.Grubosc) + "  " + dataSzuflada.Ilosc * 2 + "\n" +
                                   "S" + ((dataSzuflada.Numer + 1) / 2) + "  " + (dataSzuflada.Dlugosc) + "  " + (dataSzuflada.Szerokosc - (dataSzuflada.Grubosc * 2)) + "  " + dataSzuflada.Ilosc;
            }
            else
            {
                acMText.Contents = "Elementy szuflady\n" +
                               dataSzuflada.Numer + "sz  " + (dataSzuflada.Dlugosc) + "  " + (dataSzuflada.Wysokosc - 40) + "  " + dataSzuflada.Ilosc * 2 + "\n" +
                               (dataSzuflada.Numer + 1) + "sz  " + (dataSzuflada.Szerokosc - (dataSzuflada.Grubosc * 2)) + "  " + (dataSzuflada.Wysokosc - 40 - 12 - dataSzuflada.Grubosc) + "  " + dataSzuflada.Ilosc * 2 + "\n" +
                               "SH" + ((dataSzuflada.Numer + 1) / 2) + "  " + (dataSzuflada.Dlugosc) + "  " + (dataSzuflada.Szerokosc - (dataSzuflada.Grubosc * 2) + 22) + "  " + dataSzuflada.Ilosc;
            }

            return new List<MText> { acMText };
        }

        public static List<MText> ZwyklaText(DataSzuflada dataSzuflada)
        {
            var acMText = new MText();
            acMText.SetDatabaseDefaults();
            acMText.Location = new Point3d(dataSzuflada.Startx + dataSzuflada.Szerokosc + 200, dataSzuflada.Starty + dataSzuflada.Dlugosc, 0);
            acMText.Width = 800;

            if (dataSzuflada.Spod)
            {
                acMText.Contents = "Elementy szuflady\n" +
                                   dataSzuflada.Numer + "sz  " + (dataSzuflada.Dlugosc) + "  " + (dataSzuflada.Wysokosc - 30) + "  " + dataSzuflada.Ilosc * 2 + "\n" +
                                   (dataSzuflada.Numer + 1) + "sz  " + (dataSzuflada.Szerokosc - (dataSzuflada.Grubosc * 2)) + "  " + (dataSzuflada.Wysokosc - 30 - dataSzuflada.Grubosc) + "  " + dataSzuflada.Ilosc * 2 + "\n" +
                                   "S" + ((dataSzuflada.Numer + 1) / 2) + "  " + (dataSzuflada.Dlugosc) + "  " + (dataSzuflada.Szerokosc - (dataSzuflada.Grubosc * 2)) + "  " + dataSzuflada.Ilosc;
            }
            else
            {
                acMText.Contents = "Elementy szuflady\n" +
                                   dataSzuflada.Numer + "sz  " + (dataSzuflada.Dlugosc) + "  " + (dataSzuflada.Wysokosc - 30) + "  " + dataSzuflada.Ilosc * 2 + "\n" +
                                   (dataSzuflada.Numer + 1) + "sz  " + (dataSzuflada.Szerokosc - (dataSzuflada.Grubosc * 2)) + "  " + (dataSzuflada.Wysokosc - 30) + "  " + dataSzuflada.Ilosc * 2 + "\n" +
                                   "S" + ((dataSzuflada.Numer + 1) / 2) + "  " + (dataSzuflada.Dlugosc) + "  " + (dataSzuflada.Szerokosc) + "  " + dataSzuflada.Ilosc;
            }

            return new List<MText> { acMText };
        }
    }
}