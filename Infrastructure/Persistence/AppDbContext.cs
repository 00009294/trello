using System.Net.Mail;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Board> Boards { get; set; }
    public DbSet<Attachment> Attachments { get; set; }
    public DbSet<Desk> Desks { get; set; }
    public DbSet<Card> Cards { get; set; }

}