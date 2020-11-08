﻿using Microsoft.EntityFrameworkCore;

namespace OwensDoug.Core.User
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }
        public DbSet<Entity.UserEntity> User { get; set; }
    }
}
