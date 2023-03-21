using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiTutorial1.ViewModels
{
    public partial class ClassroomPageViewModel : ObservableObject
    {
        ObservableCollection<string> classroomList;

        [ObservableProperty]
        string text;
        [ObservableProperty]
        string code;
       

        public ClassroomPageViewModel() { }


    }
}
