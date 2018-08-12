using HostMgd.EditorInput;
using Teigha.Geometry;

namespace NanoCadRysSzuflada
{
    public class GetFromNanoCad
    {
        public static Point3d GetCoordinates()
        {
            var acDoc = HostMgd.ApplicationServices.Application.DocumentManager.MdiActiveDocument;


            var pPtOpts = new PromptPointOptions("")
            {
                Message = "\nEnter the start point of object: "
            };

            // Prompt for the start point
            var pPtRes = acDoc.Editor.GetPoint(pPtOpts);
            var ptStart = pPtRes.Value;

            // Exit if the user presses ESC or cancels the command
            if (pPtRes.Status == PromptStatus.Cancel) return ptStart;
            return ptStart;
        }
    }
}