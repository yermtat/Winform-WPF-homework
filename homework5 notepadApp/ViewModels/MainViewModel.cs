using GalaSoft.MvvmLight;
using homework5_notepadApp.Models;
using homework5_notepadApp.Services;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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

public class MainViewModel : ViewModelBase
{
    private NotepadModel notepad = new();

    public NotepadModel Notepad { get => notepad; set => Set(ref notepad, value); }

    public ButtonCommand SaveButton 
    { get => new(
        () =>
        {
            FileOperationsService.SaveFile(Notepad.NotePadName, Notepad.Text);
        }
        );
    }
    public ButtonCommand SaveAsButton
    { get => new(
        () =>
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = Notepad.NotePadName; // Default file name
            dlg.DefaultExt = ".text"; // Default file extension
            dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            // Process save file dialog box results
            if (dlg.ShowDialog() == true)
            {
                FileOperationsService.SaveFile(dlg.FileName, Notepad.Text);
                Notepad.NotePadName = dlg.FileName;
            }
        }
        ); 
    }

    public ButtonCommand OpenButton
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

    public ButtonCommand NewButton 
    {
        get => new(
            () =>
            {
                Notepad.Text = "";
                Notepad.NotePadName = "new text";
            }
            );
    }

    public ButtonCommand ExitButton
    {
        get => new(
            () =>
            {
                var DialogResult = MessageBox.Show("All the data will be deleted. Do yo want to save?", "Exit", MessageBoxButton.YesNoCancel, MessageBoxImage.Warning);

                if (DialogResult == MessageBoxResult.Yes)
                {
                    if (Notepad.NotePadName == "new text")
                        SaveAsButton.Execute(null);
                    else
                        SaveButton.Execute(null);
                    App.Current.Shutdown();
                }
                else if (DialogResult == MessageBoxResult.No)
                    App.Current.Shutdown();
            });
    }


}
