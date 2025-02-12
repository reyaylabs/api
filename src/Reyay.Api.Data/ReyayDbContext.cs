using Microsoft.EntityFrameworkCore;

namespace Reyay.Api.Data;

/// <summary>
/// Represents the database context for the Reyay application, inheriting from <see cref="DbContext"/>.
/// This context is responsible for interacting with the database and managing entity objects.
/// </summary>
public class ReyayDbContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ReyayDbContext"/> class.
    /// </summary>
    /// <param name="options">The options to be used by the <see cref="DbContext"/>. 
    /// This includes configuration settings such as the connection string and database provider.</param>
    public ReyayDbContext(DbContextOptions<ReyayDbContext> options) : base(options)
    {
    }
}