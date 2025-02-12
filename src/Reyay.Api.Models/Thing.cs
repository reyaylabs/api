namespace Reyay.Api.Models;

/// <summary>
/// DTO for Things.
/// </summary>
public class Thing
{
    public Guid Id { get; set; }
    public DateTimeOffset Timestamp { get; set; }
    public required string Origin { get; set; }
    public required string Type { get; set; }
    public required List<string> Tags { get; set; }
}
