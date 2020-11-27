using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo4.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.DataEncryption;
using Microsoft.EntityFrameworkCore.DataEncryption.Providers;

namespace Demo4.Server.Service
{
    public class DatabaseContext : DbContext
    {
        #region Crypto
        // TODO: Flytt ut til config
        private readonly byte[] _encryptionKey = Convert.FromBase64String("QpkeIoI/OtAmegQA+VnQDTnSEX9qIOUDii6j7DNEL/Q=");
        private readonly byte[] _encryptionIV = Convert.FromBase64String("e5XoOaAbtQ1NcVFu2uPZZg==");
        private readonly IEncryptionProvider _provider;
        #endregion

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            this._provider = new AesProvider(this._encryptionKey, this._encryptionIV);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // OnModelCreating: Her legger man "alt" av tilpasninger av database schema og bruk. 
            modelBuilder.UseEncryption(this._provider);
        }



        public virtual DbSet<AppUser> User { get; set; }
        //public virtual DbSet<MyModel.BrukerInfo> BlogPosts { get; set; }
        //public virtual DbSet<MyModel.Department> Department { get; set; }

        public virtual DbSet<Questionare> Questionares { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<AnswerAlteratives> AnswerAlteratives { get; set; }

        /*
        Entity Framework Core is a modern object-database mapper for .NET.
        It supports LINQ queries, change tracking, updates, and schema migrations.EF Core works with 
        InMemory, SQL Server, Azure SQL Database, SQLite, Azure Cosmos DB, MySQL, PostgreSQL, and other databases through a provider plugin API.
        */

    }
}
