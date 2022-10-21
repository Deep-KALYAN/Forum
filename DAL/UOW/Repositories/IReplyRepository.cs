using Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.UOW.Repositories
{
     public interface IReplyRepository : IGenericRepository<Reply>
    {
        Task<IEnumerable<Reply>> GetAllByTopicIdAsync(int replyId);
        

        //Task<Reply> CreateAsync(Reply reply);
        //Task<bool> DeleteAsync(int id);
        //Task<IEnumerable<Reply>> GetAllAsync();
        //Task<Reply> GetByIdAsync(int id);
        //Task<Reply> UpdateAsync(Reply reply);
    }
}