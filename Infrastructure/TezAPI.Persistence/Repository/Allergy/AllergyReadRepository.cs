using Microsoft.EntityFrameworkCore;
using TezAPI.Application.Repositories;
using TezAPI.Domain.Entities;
using TezAPI.Persistence.Contexts;

namespace TezAPI.Persistence.Repository;

public class AllergyReadRepository : ReadRepository<Domain.Entities.Allergy>, IAllergyReadRepository
{
    public AllergyReadRepository(TezAPIDbContext context) : base(context)
    {

    }
    public async Task<Allergy> GetRandomAllergyAsync()
    {
        // Get all allergies from the database
        var allergies = await Table.ToListAsync();

        if (allergies.Count > 0)
        {
            // Shuffle the list of allergies
            Shuffle(allergies);

            // Return the first (random) allergy
            return allergies.First();
        }
        else
        {
            return null; // No allergies found
        }
    }

    // Helper method to shuffle a list using Fisher-Yates algorithm
    private static void Shuffle<T>(IList<T> list)
    {
        var random = new Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}

