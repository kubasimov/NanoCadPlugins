using Teigha.Runtime;

namespace NanoCadRysSzuflada
{
    public class Command
    {
        [CommandMethod("RysowanieSzuflady")]
        public static void Szuflady()
        {
            var form = new FrmRysSzuflada();
            HostMgd.ApplicationServices.Application.ShowModalDialog(form);


        }
    }
}