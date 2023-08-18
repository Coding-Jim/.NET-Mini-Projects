namespace GuestBookLibrary;

public class GuestModel
{
    public string Name { get; set; }

    public int Age { get; set; }
    public string MessageToHost { get; set; }

    public string GuestInfo
    {
        get
        {
            return
                $"Name: {Name} {Environment.NewLine}" +
                $"Age: {Age} {Environment.NewLine}" +
                $"Message: {MessageToHost}";
        }
    }

}
