using System.IO;
using System.Text.Json;
using System.Collections.ObjectModel;

public class MyDataItem
{
    public string Name { get; set; }
    public string Description { get; set; }
}

public class MainPageViewModel
{
    public ObservableCollection<MyDataItem> Items { get; set; }

    public MainPageViewModel()
    {
        Items = new ObservableCollection<MyDataItem>();
        LoadData();
    }

    private void LoadData()
    {
        string jsonFilePath = @"C:\Users\User\Desktop\courses.json";

        if (File.Exists(jsonFilePath))
        {
            string json = File.ReadAllText(jsonFilePath);
            var items = JsonSerializer.Deserialize<List<MyDataItem>>(json);
            if (items != null)
            {
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
        }
    }
}
