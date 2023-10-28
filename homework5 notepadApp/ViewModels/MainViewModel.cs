using homework5_notepadApp.Models;
using homework5_notepadApp.Services;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace homework5_notepadApp.ViewModels;

public class ButtonCommand : ICommand
{
    public event EventHandler? CanExecuteChanged;

    private Action _action;

    public ButtonCommand(Action action)
    {
        _action = action;
    }

    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        _action();
    }
}

public class MainViewModel
{
    public NotepadModel Notepad { get; set; } = new();


    public ButtonCommand saveButton 
    { get => new(
        () =>
        {
            FileOperationsService.SaveFile(Notepad.notePadName, Notepad.Text);
        }
        );
    }
    public ButtonCommand saveAsButton
    { get => new(
        () =>
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = Notepad.notePadName; // Default file name
            dlg.DefaultExt = ".text"; // Default file extension
            dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            // Process save file dialog box results
            if (dlg.ShowDialog() == true)
            {
                FileOperationsService.SaveFile(dlg.FileName, Notepad.Text);
                Notepad.notePadName = dlg.FileName;
            }
        }
        ); 
    }

    public ButtonCommand openButton
    {
        get => new(

          () =>
          {
              Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
              dlg.Filter = "Text documents (.txt)|*.txt";

              if (dlg.ShowDialog() == true)
              {
                 Notepad = FileOperationsService.OpenFile(dlg.FileName);
              }
          }
          );
    }

    public ButtonCommand newButton 
    {
        get => new(
            () =>
            {
                Notepad.Text = "";
                Notepad.notePadName = "new text";
            }
            );
    }
}
