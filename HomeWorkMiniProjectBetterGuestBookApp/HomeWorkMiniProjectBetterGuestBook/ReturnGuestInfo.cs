using GuestBookLibrary;

namespace HomeWorkMiniProjectBetterGuestBook;

public class ReturnGuestInfo
{
    public static void GuestInfo(List<GuestModel> guests)
    {
        foreach (GuestModel g in guests)
        {
            Console.WriteLine(g.GuestInfo);
        }
    }
}
