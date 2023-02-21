using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Music_store.Model.data;

namespace Music_store.Model
{
    public class StoreDbContext:DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {

        }
        public DbSet<Music> musics { get; set; }
        public DbSet<MusicGenres> musicsGenres { get;set; }
        public DbSet<UserRoles> Roles { get; set;}
        public DbSet<User> Users { get;set; }
    }
}
