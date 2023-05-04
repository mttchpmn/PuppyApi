namespace Api.Models;

public record UpdatePuppyInput(Guid Key, string Name, int Age, string Breed, string PhotoUrl);