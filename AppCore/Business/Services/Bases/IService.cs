using AppCore.Business.Models.Results;
using AppCore.DataAccess.EntityFramework.Bases;
using Microsoft.EntityFrameworkCore;

namespace AppCore.Business.Services.Bases
{
    public interface IService<TModel, TEntity, TDbContext> :IDisposable where TModel : class, new() where TEntity : class, new() where TDbContext : DbContext, new()
    {
        RepoBase<TEntity, TDbContext> Repo { get; set; }
        IQueryable<TModel> Query();
        Result Add(TModel model); // 1, 0, 2, 3
        Result Update(TModel model);
        Result Delete(int id);
    }
}
