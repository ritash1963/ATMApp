using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CardType> CardTypesTbl { get; set; }
        public DbSet<OperationType> OperationTypesTbl { get; set; }
        public DbSet<DocumentType> DocumentTypesTbl { get; set; }
        public DbSet<Account> AccountsTbl { get; set; }
        public DbSet<Card> CardsTbl { get; set; }
        public DbSet<Operation> OperationsTbl { get; set; }
        
    }
}