namespace Api.Models;

public class Puppy
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Breed { get; set; }
    public string PhotoUrl { get; set; }
    public AdoptionStatus AdoptionStatus { get; set; }
}