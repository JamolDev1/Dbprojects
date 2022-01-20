using lesson1.Entities;
using Microsoft.EntityFrameworkCore;

namespace lesson1.Data;

public class Lesson1Db: DbContext
{
    public DbSet<Account> AccountDb { get; set; }
    
    public Lesson1Db(DbContextOptions<Lesson1Db> options)
    : base(options) {}
} 