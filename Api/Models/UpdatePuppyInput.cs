namespace Api.Models;

public record UpdatePuppyInput(int Id, string Name, int Age, string Breed, string PhotoUrl);