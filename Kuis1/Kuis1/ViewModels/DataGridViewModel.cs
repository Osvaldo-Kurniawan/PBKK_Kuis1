using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Kuis1.Core.Models;
using Kuis1.Core.Services;

using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace Kuis1.ViewModels
{
    public class DataGridViewModel : ObservableObject
    {
        public ObservableCollection<SamplePhoto> Source { get; } = new ObservableCollection<SamplePhoto>();

        public DataGridViewModel()
        {
        }

        public async Task LoadDataAsync()
        {
            Source.Clear();

            // Replace this with your actual data
            var data = await SampleDataService.GetGridDataAsync();

            foreach (var item in data)
            {
                Source.Add(item);
            }
        }
    }
}
