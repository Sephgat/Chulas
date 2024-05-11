using Chulas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace Chulas.Data
{
    public class WebSiteRepo : IWebSiteRepo
    {

        PhotoDbContext context;
        public WebSiteRepo(PhotoDbContext c)
        {
            context = c;
        }
        public int DeletePhotos(int id)
        {
            PhotoModel photo = context.Photos.SingleOrDefault(p => p.PhotoId == id);
            context.Photos.Remove(photo);
            return context.SaveChanges();
        }

        public List<PhotoModel> GetPhotos()
        {
            return context.Photos.ToList();
        }

        public async Task<PhotoModel> GetPhotosByIdAsync(int id)
        {
            var photo = await context.Photos.FindAsync(id);
            return photo;
        }

        public async Task<int> StorePhotosAsync(PhotoModel photo)
        {
            await context.AddAsync(photo);
            return await context.SaveChangesAsync();
        }


        public async Task<int> AddAppUser(AppUser appUser)
        {
            await context.AddAsync(appUser);
            return await context.SaveChangesAsync();
        }

        public async Task<int>AddBlogPost(BlogPost blogPost)
        {
            await context.AddAsync(blogPost);
            return await context.SaveChangesAsync();
        }

        public async Task<int> AddMenuItem(MenuItem menuItem)
        {
            await context.AddAsync(menuItem);
            return await context.SaveChangesAsync();
        }

        public async Task<int> AddSpecialItem(SpecialItem specialItem)
        {
            await context.AddAsync(specialItem);
            return await context.SaveChangesAsync();
        }

        public List<BlogPost> GetBlogPosts()
        {
            return context.BlogPosts.ToList();
        }

        public Task<int> DeleteBlogId(int blogId)
        {
            var blogPost = context.BlogPosts.Find(blogId);
            context.BlogPosts.Remove(blogPost);
            return context.SaveChangesAsync();
        }

        public Task<int> UpdateBlogPost(BlogPost blogPost)
        {
            context.Update(blogPost);

            return context.SaveChangesAsync();
        }

        public List<MenuItem> GetMenuItem()
        {
            return context.MenuItems.ToList();
        }

        public Task<int> DeleteMenuItem(int MenuId)
        {
            var menuItem = context.BlogPosts.Find(MenuId);
            context.BlogPosts.Remove(menuItem);
            return context.SaveChangesAsync();
        }

        public Task<int> UpdateMenu(MenuItem menuItem)
        {
            context.Update(menuItem);

            return context.SaveChangesAsync();
        }

        public List<SpecialItem> GetSpecItem()
        {
            return context.SpecialItems.ToList();
        }

        public Task<int> DeleteSpecItem(int specItemId)
        {
            var specMenuItem = context.BlogPosts.Find(specItemId);
            context.BlogPosts.Remove(specMenuItem);
            return context.SaveChangesAsync();
        }

        public Task<int> UpdateSpecItem(SpecialItem specialItem)
        {
            context.Update(specialItem);

            return context.SaveChangesAsync();
        }
    }
}
