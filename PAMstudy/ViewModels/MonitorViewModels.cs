using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using PAMstudy.Services;


namespace PAMstudy.ViewModels
{
    public partial class MonitorViewModels : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Models.Monitor> monitores;


        public MonitorViewModels() {
            getMonitoresCommand = new Command(getMonitores);
            getMonitoresCommand.Execute(this);
        
        }

        private ICommand getMonitoresCommand { get; }

        public async void getMonitores()
        {
            monitores = await new MonitorServices().GetAllMonitorAsync(); 
        }
   
        
    }
}
