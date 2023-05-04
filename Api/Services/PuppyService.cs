using Api.Models;

namespace Api.Services;

public class PuppyService : IPuppyService
{
    private readonly Dictionary<Guid, Puppy> _puppies = new ();
    
    public Puppy? GetPuppyByKey(Guid key)
    {
        var puppy = GetPuppy(key);

        return puppy?.AdoptionStatus == AdoptionStatus.Available 
            ? puppy
            : null;
    }

    public IEnumerable<Puppy> GetPuppies()
    {
        var puppies = _puppies.Values.Where(x => x.AdoptionStatus == AdoptionStatus.Available).ToList();

        return puppies;
    }

    public Puppy AddPuppy(CreatePuppyInput input)
    {
        var key = Guid.NewGuid();
        var puppy = new Puppy(key, input.Name, input.Age, input.Breed, input.PhotoUrl);

        _puppies.Add(key, puppy);

        return puppy;
    }

    public Puppy? UpdatePuppy(UpdatePuppyInput input)
    {
        var puppy = GetPuppy(input.Key);

        if (puppy == null)
            return null;
        
        puppy.Name = input.Name;
        puppy.Age = input.Age;
        puppy.Age = input.Age;
        puppy.Breed = input.Breed;
        puppy.PhotoUrl = input.PhotoUrl;

        return puppy;
    }

    public Puppy? AdoptPuppy(Guid key)
    {
        var puppy = GetPuppy(key);

        if (puppy == null)
            return null;

        puppy.AdoptionStatus = AdoptionStatus.Adopted;

        return puppy;
    }

    private Puppy? GetPuppy(Guid key)
    {
        var exists = _puppies.TryGetValue(key, out var puppy);

        if (!exists || puppy == null)
            return puppy;
        return puppy;
    }
}