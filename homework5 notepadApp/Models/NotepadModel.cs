using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5_notepadApp.Models;

public class NotepadModel : ViewModelBase
{
    private string text;
    public string Text { get => text; set => Set(ref text, value); }

    public string NotePadName { get; set; } = "new text";


}
