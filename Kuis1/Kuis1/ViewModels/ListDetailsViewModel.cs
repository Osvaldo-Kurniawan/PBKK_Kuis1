using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using Kuis1.Core.Models;
using Kuis1.Core.Services;

using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Uwp.UI.Controls;

namespace Kuis1.ViewModels
{
    public class ListDetailsViewModel : ObservableObject
    {
        private SamplePhoto _selected;

        public SamplePhoto Selected
        {
            get { return _selected; }
            set { SetProperty(ref _selected, value); }
        }

        public ObservableCollection<SamplePhoto> SampleItems { get; private set; } = new ObservableCollection<SamplePhoto>();

        public ListDetailsViewModel()
        {
        }

        public async Task LoadDataAsync(ListDetailsViewState viewState)
        {
            SampleItems.Clear();

            var data = await SampleDataService.GetListDetailsDataAsync();

            foreach (var item in data)
            {
                SampleItems.Add(item);
            }

            if (viewState == ListDetailsViewState.Both)
            {
                Selected = SampleItems.First();
            }
        }
    }
}
