using System;
using System.Windows.Forms;

namespace NanoCadRysSzuflada
{
    public partial class FrmRysSzuflada : Form
    {
        private readonly Draw _draw = new Draw();

        public FrmRysSzuflada()
        {
            InitializeComponent();
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            var dataSzuflada = GetDataFromForm();

            DrawDrawer(dataSzuflada);
        }

        private void DrawDrawer(DataSzuflada dataSzuflada)
        {

            var ptStart = GetFromNanoCad.GetCoordinates();

            dataSzuflada.Startx = ptStart.X;
            dataSzuflada.Starty = ptStart.Y;


            if (dataSzuflada.Tandem)
            {
                dataSzuflada.Szerokosc = dataSzuflada.Szerokosc - 49 + (2*dataSzuflada.Grubosc);
                dataSzuflada.Dlugosc -= 10;

                //list rectangle
                var polylines = MyRectangle.TandemRectangle(dataSzuflada);

                //list dimension
                var rotatedDimensions = MyDimension.TandemDimension(dataSzuflada);


                // Create a multiline text object
                var acMTexts = MyText.TandemText(dataSzuflada);

                _draw.DrawObject(polylines, rotatedDimensions, acMTexts);
            }
            else
            {
                dataSzuflada.Szerokosc = dataSzuflada.Szerokosc - 26;
                //list rectangle
                var polylines = MyRectangle.TandemRectangle(dataSzuflada);

                //list dimension
                var rotatedDimensions = MyDimension.TandemDimension(dataSzuflada);


                // Create a multiline text object
                var acMTexts = MyText.ZwyklaText(dataSzuflada);

                _draw.DrawObject(polylines, rotatedDimensions, acMTexts);
            }
        }

        private DataSzuflada GetDataFromForm()
        {
            return new DataSzuflada
            {
                Dlugosc = Convert.ToInt32(txtDlugosc.Text),
                Szerokosc = Convert.ToInt32(txtSzerokosc.Text),
                Wysokosc = Convert.ToInt32(txtWysokosc.Text),
                Grubosc = Convert.ToInt32(txtGrubosc.Text),
                Ilosc = Convert.ToInt32(txtIlosc.Text),
                Numer = Convert.ToInt32(txtNumer.Text),
                Tandem = radioSzuflada2.Checked,
                Spod = radioSpod2.Checked,
                Startx = 0,
                Starty = 0
            };
        }


        private void butCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
