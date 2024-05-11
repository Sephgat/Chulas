using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Chulas.Data;
using Chulas.Models;

namespace Chulas.Controllers
{
    public class PhotosController : Controller
    {
        IWebSiteRepo repository;
        PhotoDbContext context;
        public PhotosController(IWebSiteRepo m)
        {
            repository = m;
        }
        public IActionResult Index()
        {
            var photos = repository.GetPhotos();
            return View(photos);
        }
        [HttpGet]
        public IActionResult Add(int id)
        {
            ViewBag.Action = "Add";
            //var photo = repository.GetPhotosByIdAsync(id).Result;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(PhotoUploadModel model)
        {
            if (model.file.Length > 0)
            {
                using (var stream = new MemoryStream())
                {
                    await model.file.CopyToAsync(stream);
                    model.Photo = stream.ToArray();
                }
            }

            if (model.Photo != null)
            {
                await repository.StorePhotosAsync(new PhotoModel
                {
                    PhotoName = model.PhotoName,
                    PhotoDescription = model.PhotoDescription,
                    Photo = model.Photo
                });
            }

            return RedirectToAction("Index", "Photos");
        }
        [Authorize]
        public async Task<IActionResult> Delete(int photoId)
        {
            var photo = await repository.GetPhotosByIdAsync(photoId);
            return View(photo);
        }
        [HttpPost]
        public IActionResult Delete(PhotoModel model)
        {
            repository.DeletePhotos(model.PhotoId);
            return RedirectToAction("Index", "Photos");
        }
    }
}