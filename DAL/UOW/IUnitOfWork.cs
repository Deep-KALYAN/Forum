using DAL.UOW.Repositories;

namespace DAL.UOW
{
    public interface IUnitOfWork
    {
        IReplyRepository Replies { get; }
        IRubricRepository Rubrics { get; }
        ITopicRepository Topics { get; }
        IUserRepository Users { get; }

        void BeginTransaction();
        void Commit();
        void RollBack();
    }
}