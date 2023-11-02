using homework5_notepadApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5_notepadApp.Services;

public static class FileOperationsService
{
    public static void SaveFile(string fileName, string text)
    {
        using FileStream fs = new(fileName, FileMode.Create);
        using StreamWriter sw = new StreamWriter(fs);

        sw.WriteLine(text);

    }

    public static NotepadModel OpenFile(string fileName)
    {
        using FileStream fs = new(fileName, FileMode.Open);
        using StreamReader sr = new StreamReader(fs);

        NotepadModel nt = new NotepadModel() { NotePadName= fileName, Text = sr.ReadToEnd() };

        return nt;
    }
}
