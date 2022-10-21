using DAL.UOW.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UOW
{
    class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly IDBSession _dBSession;
        public UnitOfWork(IDBSession dBSession)
        {
            _dBSession = dBSession;
        }

        public void BeginTransaction()
        {
            _dBSession.Transaction = _dBSession.Connection.BeginTransaction();
        }
        public void Commit()
        {
            if (_dBSession.Transaction != null)
                _dBSession.Transaction.Commit();

            _dBSession.Transaction = null;
            // or // _dBSession.Transaction?.Commit();
        }

        public void RollBack()
        {
            //Le Point ? remplace le if
            _dBSession.Transaction?.Rollback();

            _dBSession.Transaction = null;
        }

        public void Dispose()
        {
            Commit();

        }

        /*Need to define the repositories then extract Interface*/
        public IUserRepository Users { get => new UserRepository(_dBSession); }
        public IReplyRepository Replies { get => new ReplyRepository(_dBSession); }
        public ITopicRepository Topics { get => new TopicRepository(_dBSession); }
        public IRubricRepository Rubrics { get => new RubricRepository(_dBSession); }
    }
}
