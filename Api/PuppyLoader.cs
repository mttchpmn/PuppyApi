using System.Text.Json;
using Api.Controllers;
using Api.Models;

namespace Api;

public class PuppyLoader
{
    public static void LoadPuppies(IPuppyService puppyService, string puppiesInputPath)
    {
        var fileContent = File.ReadAllText(puppiesInputPath);
        var puppiesList = JsonSerializer.Deserialize<List<CreatePuppyInput>>(fileContent, new JsonSerializerOptions{PropertyNameCaseInsensitive = true});

        if (puppiesList == null)
            throw new InvalidOperationException("Unable to load puppies input file");

        foreach (var puppy in puppiesList)
        {
            puppyService.AddPuppy(puppy);
        }
    }
}