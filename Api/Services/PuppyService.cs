using Api.Controllers;
using Api.Models;

namespace Api.Services;

public class PuppyService : IPuppyService
{
    public Puppy? GetPuppyById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Puppy> GetPuppies()
    {
        throw new NotImplementedException();
    }

    public Puppy AddPuppy(CreatePuppyInput input)
    {
        throw new NotImplementedException();
    }

    public Puppy UpdatePuppy(UpdatePuppyInput input)
    {
        throw new NotImplementedException();
    }

    public Puppy AdoptPuppy(int id)
    {
        throw new NotImplementedException();
    }
}