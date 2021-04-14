using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using System.IO;
using Newtonsoft.Json;

namespace LAB6_7
{
    public class SerializeCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ObservableCollection<ObjectClasses.Game> games = parameter as ObservableCollection<ObjectClasses.Game>;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                string filepath = saveFileDialog.FileName;
                using (StreamWriter sw = new StreamWriter(filepath, true))
                {
                    string serialize = JsonConvert.SerializeObject(games, Formatting.Indented);
                    sw.Write(serialize);

                    sw.Close();
                }
            }
        }
    }
}
