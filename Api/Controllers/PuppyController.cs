using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class PuppyController : ControllerBase
{
    private readonly IPuppyService _puppyService;

    public PuppyController(IPuppyService puppyService)
    {
        _puppyService = puppyService;
    }
    
    [HttpGet]
    [Route("{id:int}")]
    public IActionResult GetPuppy(int id)
    {
        var puppy = _puppyService.GetPuppyById(id);

        return puppy != null
            ? Ok(puppy)
            : NotFound();
    }
    
    [HttpGet]
    public IActionResult GetPuppies()
    {
        var puppies = _puppyService.GetPuppies();
        
        return Ok(puppies);
    }

    [HttpPost]
    public IActionResult AddPuppy(CreatePuppyInput input)
    {
        var newPuppy = _puppyService.AddPuppy(input);

        return Created("", newPuppy);
    }

    [HttpPut]
    public IActionResult UpdatePuppy(UpdatePuppyInput input)
    {
        var updatedPuppy = _puppyService.UpdatePuppy(input);

        return Ok(updatedPuppy);
    }

    [HttpGet]
    [Route("{id:int}")]
    public IActionResult AdoptPuppy(int id)
    {
        _puppyService.AdoptPuppy(id);

        return NoContent();
    }
}

public interface IPuppyService
{
    Puppy? GetPuppyById(int id);
    IEnumerable<Puppy> GetPuppies();
    Puppy AddPuppy(CreatePuppyInput input);
    Puppy UpdatePuppy(UpdatePuppyInput input);
    Puppy AdoptPuppy(int id);
}