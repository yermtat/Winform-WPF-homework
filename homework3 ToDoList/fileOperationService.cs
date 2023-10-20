using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace homework3_ToDoList;

public static class fileOperationService
{
    public static void SaveToFile(BindingList<toDoItem> toDoList)
    {
        using FileStream fs = new("toDoList.json", FileMode.Truncate);
        using StreamWriter sw = new(fs);

        string json = JsonSerializer.Serialize(toDoList);
        sw.WriteLine(json);
    }

    public static BindingList<toDoItem> LoadFromFile()
    {
        using FileStream fs = new("toDoList.json", FileMode.OpenOrCreate);
        using StreamReader sr = new(fs);

        string json = sr.ReadToEnd();

        return JsonSerializer.Deserialize<BindingList<toDoItem>>(json) ?? new BindingList<toDoItem>();
    }
}
