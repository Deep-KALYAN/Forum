using Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.UOW.Repositories
{
    public interface ITopicRepository : IGenericRepository<Topic>
    {
        //Méthodes spécifiques aux Topics
        Task<IEnumerable<Topic>> GetAllByRubricIdAsync(int rubricId);



        // To work with view RUBRICS_DETAIL
        Task<IEnumerable<TopicDetail>> DetailByIdAsync(int id);
        Task<IEnumerable<TopicDetail>> DetailAsync();

        //Task<Topic> CreateAsync(Topic topic);
        //Task<bool> DeleteAsync(int id);
        //Task<IEnumerable<Topic>> GetAllAsync();
        //Task<Topic> GetByIdAsync(int id);
        //Task<Topic> UpdateAsync(Topic topic);
    }
}