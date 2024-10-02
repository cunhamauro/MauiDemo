using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiControls.Models
{
    public class PhotoViewModel
    {
        public ObservableCollection<Photo> photos { get; private set; }
        public ObservableCollection<Photo> Photos
        {
            get { return photos; }
            set { photos = value; }
        }

        public PhotoViewModel()
        {
            Photos = new ObservableCollection<Photo>()
            {
                new Photo() {Name = "Andromeda", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSucaVHHANiEk8VF5jcKdQ3P5v4pfj6nWAOeA&s"},
                new Photo() {Name = "Milky Way", ImageUrl = "https://cdn.shopify.com/s/files/1/1935/4371/files/MilkyWay_Hills_a96e4e48-740b-4833-890b-1cdafc382225.jpg?v=1659042183"},
                new Photo() {Name = "Universe", ImageUrl = "https://cdn.mos.cms.futurecdn.net/owm4oa3hXUG58mka7hPvfP-1200-80.jpg"},
                new Photo() {Name = "Galaxy", ImageUrl = "https://i.natgeofe.com/n/e484088d-3334-4ab6-9b75-623f7b8505c9/1086.jpg"},
                new Photo() {Name = "Sombrero", ImageUrl = "https://cdn.esahubble.org/archives/images/large/opo0328b.jpg"},
                new Photo() {Name = "Andromeda", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSucaVHHANiEk8VF5jcKdQ3P5v4pfj6nWAOeA&s"},
                new Photo() {Name = "Milky Way", ImageUrl = "https://cdn.shopify.com/s/files/1/1935/4371/files/MilkyWay_Hills_a96e4e48-740b-4833-890b-1cdafc382225.jpg?v=1659042183"},
                new Photo() {Name = "Universe", ImageUrl = "https://cdn.mos.cms.futurecdn.net/owm4oa3hXUG58mka7hPvfP-1200-80.jpg"},
                new Photo() {Name = "Galaxy", ImageUrl = "https://i.natgeofe.com/n/e484088d-3334-4ab6-9b75-623f7b8505c9/1086.jpg"},
                new Photo() {Name = "Sombrero", ImageUrl = "https://cdn.esahubble.org/archives/images/large/opo0328b.jpg"},
                new Photo() {Name = "Andromeda", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSucaVHHANiEk8VF5jcKdQ3P5v4pfj6nWAOeA&s"},
                new Photo() {Name = "Milky Way", ImageUrl = "https://cdn.shopify.com/s/files/1/1935/4371/files/MilkyWay_Hills_a96e4e48-740b-4833-890b-1cdafc382225.jpg?v=1659042183"},
                new Photo() {Name = "Universe", ImageUrl = "https://cdn.mos.cms.futurecdn.net/owm4oa3hXUG58mka7hPvfP-1200-80.jpg"},
                new Photo() {Name = "Galaxy", ImageUrl = "https://i.natgeofe.com/n/e484088d-3334-4ab6-9b75-623f7b8505c9/1086.jpg"},
                new Photo() {Name = "Sombrero", ImageUrl = "https://cdn.esahubble.org/archives/images/large/opo0328b.jpg"},
            };
        }
    }
}
