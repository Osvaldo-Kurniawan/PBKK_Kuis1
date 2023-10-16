using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kuis1.Core.Models;

namespace Kuis1.Core.Services
{
    public static class SampleDataService
    {
        private static IEnumerable<SamplePhoto> AllPhotos()
        {
            // Simulated photo data
            var photos = new List<SamplePhoto>
            {
                new SamplePhoto
                {
                    PhotoId = 1,
                    Name = "Photo 1",
                    Description = "A beautiful landscape photo",
                    Size = "8x10",
                    FileSize = "2MB",
                    PhotoUri = "ms-appx:///Assets/photo1.jpg.jpg",
                    // Add more photo properties as needed
                },
                new SamplePhoto
                {
                    PhotoId = 2,
                    Name = "Photo 2",
                    Description = "A portrait photo",
                    Size = "8x10",
                    FileSize = "1.5MB",
                    PhotoUri = "ms-appx:///Assets/photo2.jpg",
                    // Add more photo properties as needed
                },
                // Add more photos as needed
            };

            return photos;
        }

        // Remove this once your grid page is displaying real data.
        public static async Task<IEnumerable<SamplePhoto>> GetGridDataAsync()
        {
            await Task.CompletedTask;
            return AllPhotos();
        }

        // Remove this once your ListDetails pages are displaying real data.
        public static async Task<IEnumerable<SamplePhoto>> GetListDetailsDataAsync()
        {
            await Task.CompletedTask;
            return AllPhotos();
        }
    }
}
