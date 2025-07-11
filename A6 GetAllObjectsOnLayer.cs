using System;
using NXOpen;
//changed

public class NXJournal
{
public static void Main(string[] args)
{
Session theSession = Session.GetSession();
        if (theSession.Parts.BaseWork == null)
        {
            // active part required
            return;
        }
 
        Part workPart = theSession.Parts.Work;
        ListingWindow lw = theSession.ListingWindow;
        lw.Open();
 
        
        NXObject[] theObjects = workPart.Layers.GetAllObjectsOnLayer(1);
 
        foreach (NXObject obj in theObjects)
        {
            lw.WriteFullline("object type : " + obj.GetType().ToString());
            if (obj is Body)
            {
                lw.WriteLine("  body object type found  ");
                lw.writeline(" feature is found");
            }
        }
 
        lw.Close();
    }
 
    public static int GetUnloadOption(string dummy)
    {
        // Unloads the image immediately after execution within NX
        return (int)NXOpen.Session.LibraryUnloadOption.Immediately;
    }

}


