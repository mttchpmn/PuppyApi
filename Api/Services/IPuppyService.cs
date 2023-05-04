using Api.Models;

namespace Api.Services;

public interface IPuppyService
{
    Puppy? GetPuppyByKey(Guid key);
    IEnumerable<Puppy> GetPuppies();
    Puppy AddPuppy(CreatePuppyInput input);
    Puppy? UpdatePuppy(UpdatePuppyInput input);
    Puppy? AdoptPuppy(Guid key);
}