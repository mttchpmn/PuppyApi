namespace Api.Models;

public class Puppy
{
    public Guid Key { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Breed { get; set; }
    public string PhotoUrl { get; set; }
    public AdoptionStatus AdoptionStatus { get; set; }

    public Puppy(Guid key, string name, int age, string breed, string photoUrl)
    {
        Key = key;
        Name = name;
        Age = age;
        Breed = breed;
        PhotoUrl = photoUrl;
        AdoptionStatus = AdoptionStatus.Available;
    }
}