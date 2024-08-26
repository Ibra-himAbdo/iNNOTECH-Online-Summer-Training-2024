using Bogus;

namespace StudentsAffairs.Repository.Data
{
    public static class ApplicationDataSeed
    {
        
        public static async Task SeedDataAsync(ApplicationContext context)
        {
            if (await context.Students.CountAsync() == 0)
            {
                var faker = new Faker<Student>()
                    .RuleFor(s => s.Name, f => f.Name.FullName())
                    .RuleFor(s => s.Email, f => f.Internet.Email())
                    .RuleFor(s => s.Age, f => f.Random.Int(18, 35)) 
                    .RuleFor(s => s.Mobile, f => f.Phone.PhoneNumber("012#######"));

                await context.Students.AddRangeAsync(faker.Generate(15));
                await context.SaveChangesAsync();
            }
        }
    }
}
