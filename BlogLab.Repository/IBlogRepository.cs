using BlogLab.Models.Blog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogLab.Repository
{
    public interface IBlogRepository
    {
        Task<Blog> UpsertAsync(BlogCreate blogCreate, int applicationUserId);

        Task<PageResults<Blog>> GetAllAsync(BlogPaging blogPaging);

        Task<Blog> GetAsync(int blogId);

        Task<List<Blog>> GetAllByUserIdAsync(int applicationUserId);

        Task<List<Blog>> GetAllFamousAsync();

        Task<int> DeleteAsync(int blogId);
    }
}
