using Chulas.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chulas.Data
{
    public interface IWebSiteRepo
    {
        public List<PhotoModel> GetPhotos();
        public Task<PhotoModel> GetPhotosByIdAsync(int id);
        public Task<int> StorePhotosAsync(PhotoModel photo);
        public int DeletePhotos(int id);
        public Task<int> AddAppUser(AppUser appUser);

        public Task<int> AddBlogPost(BlogPost blogPost);
        public List<BlogPost> GetBlogPosts();
        public Task<int> DeleteBlogId(int blogId);
        public Task<int> UpdateBlogPost(BlogPost blogPost);
        public Task<int> AddMenuItem(MenuItem menuItem);
        public List<MenuItem> GetMenuItem();
        public Task<int> DeleteMenuItem(int MenuId);
        public Task<int> UpdateMenu(MenuItem menuItem);
        public Task<int> AddSpecialItem(SpecialItem specialItem);
        public List<SpecialItem> GetSpecItem();
        public Task<int> DeleteSpecItem (int specItemId);
        public Task<int> UpdateSpecItem(SpecialItem specialItem);
    }
}
