using Fiorello_PB101.Data;
using Fiorello_PB101.Models;
using Fiorello_PB101.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_PB101.Services
{
    public class SocialMediaService : ISocialMediaService
    {
        private readonly AppDbContext _context;
        public SocialMediaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SocialMedia>> GetAllAsync()
        {
            return await _context.SocialMedias.ToListAsync();
        }
    }
}
