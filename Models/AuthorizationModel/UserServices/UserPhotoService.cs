using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Album.Services
{
    public class UserPhotoService: IStoredImageRepository 
    {
        private readonly AuthDbContext _context;

        public UserPhotoService(AuthDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(File image)
        {
            _context.StoredImages.Add(image);
            return await _context.SaveChangesAsync();            
        }

        public Task<File[]> GetAll()
        {
            return Task.Run(() => {
                return _context.StoredImages.ToArray();
            });
        }

        public async Task<File> GetByID(int ID)
        {
            return await _context.StoredImages.Where(i => i.ID == ID).FirstOrDefaultAsync();
        }

        public async Task<int> Remove(int ID)
        {
            var image = await GetByID(ID);
            if(image == null)
            {
                return 0;
            }
            else
            {
                _context.StoredImages.Remove(image);
                return await _context.SaveChangesAsync();
            }
            
        }

        public async Task<int> Update(File image)
        {
         
            if (image == null)
            {
                return 0;
            }
            else
            {
                _context.StoredImages.Update(image);
                return await _context.SaveChangesAsync();
            }
        }
    }
}
