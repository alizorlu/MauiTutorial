using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTutorial1.ViewModels
{
    public partial class StudentPageViewModel : ObservableObject
    {
        ObservableCollection<string> studentList;

        [ObservableProperty]
        string text;


        public StudentPageViewModel()
        {
        }
    }
}
