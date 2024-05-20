using System.ComponentModel.DataAnnotations;

namespace Test.Dotnet.Queue.Subscriber.Api.Models;

public class ItemRequest
{
    public int? Id { get; set; }
    [Required]
    public required string Name { get; set; }
}

