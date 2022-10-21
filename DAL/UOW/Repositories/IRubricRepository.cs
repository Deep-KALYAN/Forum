using Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.UOW.Repositories
{
    public interface IRubricRepository : IGenericRepository<Rubric>
    {

        // To work with view RUBRICS_DETAIL
        Task<IEnumerable<RubricDetail>> DetailByIdAsync(int id);
        Task<IEnumerable<RubricDetail>> DetailAsync();



        //Task<Rubric> CreateAsync(Rubric rubric);
        //Task<bool> DeleteAsync(int id);
        //Task<IEnumerable<Rubric>> GetAllAsync();
        //Task<Rubric> GetByIdAsync(int id);
        //Task<Rubric> UpdateAsync(Rubric rubric);
    }
}