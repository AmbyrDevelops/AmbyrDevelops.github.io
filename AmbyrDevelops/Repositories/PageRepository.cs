using AmbyrDevelops.DatabaseContext;
using AmbyrDevelops.DataTransferObjects;
using AmbyrDevelops.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmbyrDevelops.Repositories
{
    public class PageRepository : IPageRepository
    {
        private readonly ApplicationDbContext context;

        public PageRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<string> AddPageSection(PageDTO pageSection)
        {
            var newPageSection = new PageDTO
            {
                Type = pageSection.Type,
                Section = pageSection.Section,
                Title = pageSection.Title,
                Subtitle = pageSection.Subtitle,
                Excerpt = pageSection.Excerpt,
                Description = pageSection.Description,
                Image = pageSection.Image,
                Video = pageSection.Video,
                Link = pageSection.Link
            };
            context.PageSections.Add(newPageSection);
            await context.SaveChangesAsync();

            return "Page section added successfully";
        }

        public async Task<IEnumerable<PageDTO>> GetPageSectionsAsync()
        {
            return await context.PageSections.ToListAsync();
        }
    }
}
