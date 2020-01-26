using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using MyroWebApp.Xamarin.Entities;
using System.Linq;

namespace MyroWebApp.Xamarin.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<Term> Terms { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "Grades";
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            Terms.First().Courses.First().
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy) { return; }
            IsBusy = true;

            var grades = MyroWeb.GetUserGrades(ProfileStorage.CurrentProfile.Key);
            Terms = new ObservableCollection<Term>(grades.Terms);

            IsBusy = false;

            await Task.CompletedTask;
        }
    }
}
