
List<PersonModel> persons = new()
{
    new PersonModel() {FirstName="John", LastName="darnDoe", Email="john@doe.com" },
    new PersonModel() {FirstName="Sue", LastName="Storm", Email="sue@storm.com" },
    new PersonModel() {FirstName="bob", LastName="hammer", Email="bob@hammer.com" }
};

List<CarModel> cars = new()
{
    new CarModel() {Manufacturer="Audi", Model="A5"},
    new CarModel() {Manufacturer="BMWheck", Model="M5" }
};

DataAccess<PersonModel> personData = new();
personData.BadWordEvent += PersonData_BadWordEvent;
//Edit to save file to your own directory
personData.SaveToCSV(persons, @"YourDirectory\peoplesHomeWork.csv");

DataAccess<CarModel> carData = new();
carData.BadWordEvent += CarData_BadWordEvent;
//Edit to save file to your own directory
carData.SaveToCSV(cars, @"YourDirectory\carsHomeWork.csv");

void PersonData_BadWordEvent(object? sender, PersonModel e)
{
    Console.WriteLine($"{e.FirstName} {e.LastName} {e.Email} has an invalid value.");
}
void CarData_BadWordEvent(object? sender, CarModel e)
{
    Console.WriteLine($"{e.Manufacturer} {e.Model} has an invalid value.");
}


public class DataAccess<T> where T : new()
{
    public event EventHandler<T> BadWordEvent;

    public void SaveToCSV(List<T> items, string filepath)
    {
        List<string> rows = new();
        T entry = new T();
        var cols = entry.GetType().GetProperties();
        string row = "";

        foreach (var col in cols)
        {
            row += $",{col.Name}";
        }

        row = row.Substring(1);
        rows.Add(row);

        foreach (var item in items)
        {
            row = "";


            foreach (var col in cols)
            {
                bool badWordDetected = BadWordDetector(col.GetValue(item).ToString());

                if (badWordDetected == false)
                {
                    row += $",{col.GetValue(item)}";
                }
                else
                {
                    Console.WriteLine($"{col.GetValue(item)} is an invalid value.");
                    row += $",invalid value";

                    BadWordEvent?.Invoke(this, item);
                }
            }
            row = row.Substring(1);
            rows.Add(row);
        }

        //Will fail > Edit file path first at line 18 & 23
        File.WriteAllLines(filepath, rows);

        Console.WriteLine($"The following Data is written to a csv ending with {filepath.Substring(filepath.Length - 20)}");
        foreach (var r in rows)
        {
            Console.WriteLine(r);
        }
    }

    public bool BadWordDetector(string wordToCheck)
    {
        bool output = false;

        if (wordToCheck.ToLower().Contains("darn") || wordToCheck.ToLower().Contains("heck"))
        {
            output = true;
        }

        return output;
    }
}

