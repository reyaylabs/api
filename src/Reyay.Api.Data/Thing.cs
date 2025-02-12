using Microsoft.EntityFrameworkCore;

namespace Reyay.Api.Data;

[PrimaryKey(nameof(Id))]
public class Thing
{
    public Guid Id { get; set; }
    public DateTimeOffset Timestamp { get; set; }
    public required string Origin { get; set; }
    public required string Type { get; set; }
    public required List<string> Tags { get; set; }

    public Models.Thing ToModel() => new()
    {
        Id = Id,
        Timestamp = Timestamp,
        Origin = Origin,
        Type = Type,
        Tags = Tags
    };
}