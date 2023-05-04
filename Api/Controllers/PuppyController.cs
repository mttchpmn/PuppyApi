using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Controller]
[Route("[controller]")]
public class PuppyController : ControllerBase
{
    private readonly IPuppyService _puppyService;

    public PuppyController(IPuppyService puppyService)
    {
        _puppyService = puppyService;
    }

    [HttpGet]
    [Route("{key:Guid}")]
    public IActionResult GetPuppy(Guid key)
    {
        var puppy = _puppyService.GetPuppyByKey(key);

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

        return updatedPuppy != null
            ? Ok(updatedPuppy)
            : NotFound();
    }

    [HttpGet]
    [Route("adopt/{key:Guid}")]
    public IActionResult AdoptPuppy(Guid key)
    {
        var puppy = _puppyService.AdoptPuppy(key);

        return puppy != null
            ? Ok(puppy)
            : NotFound();
    }
}