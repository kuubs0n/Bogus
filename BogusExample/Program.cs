using Bogus;
using Bogus.DataSets;
using BogusExample;

Randomizer.Seed = new Random(123456789);

var testUsers = new Faker<User>()
    .RuleFor(u => u.Id, f => Guid.NewGuid())
    .RuleFor(u => u.FirstName, f => f.Name.FirstName())
    .RuleFor(u => u.LastName, f => f.Name.LastName())
    .RuleFor(u => u.Birthday, f => f.Date.BetweenDateOnly(DateOnly.Parse("1990, 01, 01"), DateOnly.Parse("2022, 01, 01")))
    .RuleFor(u => u.IsActivated, f => f.Random.Bool(0.8f));
    
var results = testUsers.GenerateLazy(100).ToList();
