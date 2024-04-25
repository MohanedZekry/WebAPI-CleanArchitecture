using PlacementTest.Application.Repository;
using PlacementTest.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacementTest.Persistence.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PlacementTestContext _context;

        public UnitOfWork(PlacementTestContext context)
        {
            _context = context;
        }
        public Task Save(CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}
