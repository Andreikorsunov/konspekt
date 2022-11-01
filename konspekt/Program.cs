using Microsoft.EntityFrameworkCore;

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder
        .Entity<User>()
        .ToTable("Users", t => t.IsTemporal(
            h =>
            {
                h.HasPeriodStart("CreatedAt");
                h.HasPeriodEnd("DeletedAt");
                h.UseHistoryTable("PeopleDataHistory");
            }));
}