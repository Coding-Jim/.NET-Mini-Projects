using GuestBookLibrary;

namespace HomeWorkMiniProjectBetterGuestBook;

public class StoreGuestInfo
{
    public static void StoreInfo(List<GuestModel> guests)
    {
        string moreGuestsComing = "";

        do
        {
            GuestModel guest = new GuestModel();

            guest.Name = GetGuestInfo.GetInfo("What is your name?: ");

            bool isValidAge = int.TryParse(GetGuestInfo.GetInfo("What is your age?: "), out int age);

            while (isValidAge == false || age < 1 || age > 130)
            {
                Console.WriteLine("This is not a valid age (numbers 1-130 only).");
                isValidAge = int.TryParse(GetGuestInfo.GetInfo("What is your age?: "), out age);
            }

            guest.Age = age;

            guest.MessageToHost = GetGuestInfo.GetInfo("What is your message to the host?: ");

            moreGuestsComing = GetGuestInfo.GetInfo("Are more guests coming (yes/no)?: ");

            guests.Add(guest);

            Console.Clear();

        } while (moreGuestsComing == "yes");
    }
}
