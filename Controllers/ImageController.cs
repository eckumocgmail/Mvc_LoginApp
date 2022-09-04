using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
 
using MVC.Album.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class ImageController : Controller
{
    private readonly ILogger<ImageController> _logger;
    private readonly IStoredImageRepository  _images;


    public ImageController(
            ILogger<ImageController> logger,
            IStoredImageRepository  images)
    {
        _logger = logger;
        _images = images;
    }


    public IActionResult Index()
    {
        _logger.LogInformation($"Index()");
        return View();
    }


    
    public IActionResult Create()
    {
        _logger.LogInformation($"Create()");
        return View(new StoredImage());
    }

    public async Task<IActionResult> Delete(int ID)
    {
        _logger.LogInformation($"Delete({ID})");
        StoredImage image = await _images.GetByID(ID);
        if (image != null)
        {

            return View(image);

        }
        else
        {
            return NotFound(ID);
        }
    }

    public async Task<IActionResult> Edit(int ID)
    {
        _logger.LogInformation($"Edit({ID})");
        StoredImage image = await _images.GetByID(ID);
        if (image != null)
        {

            return View(image);

        }
        else
        {
            return NotFound(ID);
        }
    }

    public async Task<IActionResult> Update(StoredImage model)
    {
        _logger.LogInformation($"Update({model.ID})");
        if (HttpContext.Request.HasFormContentType)
        {              
            await _images.Update(model);
            return RedirectToAction("Index");
        }
        else
        {
            throw new Exception("Неверный ContentType");
        }
    }

    public async Task<IActionResult> DeleteConfirmed(int ID)
    {
        _logger.LogInformation($"DeleteConfirmed({ID})");
        int result = await _images.Remove(ID);
        if (result != 1)
        {

            return NotFound(ID);

        }
        else
        {
            return RedirectToAction("Index");
        }
    }

        

 
    [HttpPost]
    public async Task<IActionResult> Create(StoredImage model)
    {
        _logger.LogInformation($"Create({model})");
     
        if (HttpContext.Request.HasFormContentType)
        {
            await _images.Create(model);
            return RedirectToAction("Index");
        }
        else
        {
            throw new Exception("Неверный ContentType");
        }
        /*if (HttpContext.Request.HasFormContentType)
        {
            IFormFile formFile = HttpContext.Request.Form.Files.Where(f => f.Name == "Data").FirstOrDefault();
            if (ModelState.IsValid == false || formFile == null)
            {
                if (formFile == null)
                {
                    ModelState.AddModelError("Data", "Необходимо выбрать файл для загрузки");
                }

                return View(model);

            }
            else
            {
                model.ContentType = formFile.ContentType;
                var data = new byte[formFile.Length];
                using (var sr = formFile.OpenReadStream())
                {
                    sr.Read(data, 0, (int)formFile.Length);
                }
                model.Data = data;
                await _images.Create(model);
                return RedirectToAction("Index");
            }

        }
        else
        {
            throw new Exception("Неверный ContentType");
        }*/

    }

    public async Task Show( int ID )
    {
        _logger.LogInformation($"Show({ID})");
        StoredImage image = await _images.GetByID(ID);
        if(image != null)
        {      
            Response.ContentType = image.ContentType;
            byte[] data = image.Data;
            await Response.Body.WriteAsync(data, 0, data.Length);
        }
            
    }


    public async Task ShowFromTempData()
    {
        _logger.LogInformation($"ShowFromTempData( )");
        if (TempData.ContainsKey("Image") == true)
        {
            StoredImage image = (StoredImage)TempData["Image"];
            Response.ContentType = image.ContentType;
            byte[] data = image.Data;
            await Response.Body.WriteAsync(data, 0, data.Length);

        }

    }
}
