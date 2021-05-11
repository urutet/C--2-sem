﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Controls;

namespace LAB10.ViewModels
{
    class MainWindowVM : INotifyPropertyChanged
    {
        public DataGrid dataGr { get; set; }
        public Models.DBCommandsModel dBCommands { get; }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public AddItemVM ItemVM;
        public Commands.RelayCommand OpenAddItemVM { get; set; }
        public Commands.RelayCommand RefreshDataGridCommand { get; set; }

        public MainWindowVM()
        {
            ItemVM = new AddItemVM();
            OpenAddItemVM = new Commands.RelayCommand(obj => {
                AddItemWindow window = new AddItemWindow
                {
                    DataContext = ItemVM
                };
                window.Show();
            });

            dBCommands = new Models.DBCommandsModel();

            RefreshDataGridCommand = new Commands.RelayCommand(obj =>
            {
                PCsGridUpdate();
            });
        }

        public void PCsGridUpdate()
        {
            dataGr.DataContext = dBCommands.Select().Tables[0].DefaultView;
        }

    }
}
