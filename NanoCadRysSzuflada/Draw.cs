using System.Collections.Generic;
using HostMgd.ApplicationServices;
using Teigha.DatabaseServices;

namespace NanoCadRysSzuflada
{
    public class Draw
    {
        // Get the current document and database
        //Document acDoc = Application.DocumentManager.MdiActiveDocument;
        Database acCurDb = Application.DocumentManager.MdiActiveDocument.Database;


        public void DrawObject(List<Polyline> poly2D, List<AlignedDimension> rotatedDimensions, List<MText> acMTexts)
        {
            // Start a transaction
            using (var acTrans = acCurDb.TransactionManager.StartTransaction())
            {

                // Open the Block table for read
                var acBlkTbl = acTrans.GetObject(acCurDb.BlockTableId,
                    OpenMode.ForRead) as BlockTable;

                // Open the Block table record Model space for write
                var acBlkTblRec = acTrans.GetObject(acBlkTbl[BlockTableRecord.ModelSpace],
                    OpenMode.ForWrite) as BlockTableRecord;

                // Add the new object to the block table record and the transaction

                foreach (var polyline in poly2D)
                {
                    polyline.Layer = "Korpus";
                    acBlkTblRec.AppendEntity(polyline);

                    acTrans.AddNewlyCreatedDBObject(polyline, true);
                }

                foreach (var dimension in rotatedDimensions)
                {
                    dimension.Layer = "Wymiary_korpusu";
                    acBlkTblRec.AppendEntity(dimension);

                    acTrans.AddNewlyCreatedDBObject(dimension, true);
                }
                foreach (var actext in acMTexts)
                {
                    actext.Layer = "Opisy";
                    acBlkTblRec.AppendEntity(actext);
                    acTrans.AddNewlyCreatedDBObject(actext, true);
                }


                // Save the new object to the database
                acTrans.Commit();
            }

        }
    }
}