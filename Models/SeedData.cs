using Microsoft.EntityFrameworkCore;
using C_Website.Data;
namespace C_Website.Models;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new C_WebsiteContext(
                           serviceProvider.GetRequiredService<
                                                  DbContextOptions<C_WebsiteContext>>()))
        {
            if (context == null || context.Person == null)
            {
                throw new ArgumentNullException("Null context or null Person");
            }
            // Look for any persons.
        /*    if (context.Person.Any())
            {
                return;   // DB has been seeded
            }*/

            context.Person.AddRange(
                                                  new Person { FirstName = "Jane", LastName = "Doe", numberC = "1", Phone = "5555555555" }
                                                                                    );
        /*    context.Person.AddRange(
                                   new Person("Jane", "Doe", "5555555555", "1")
                                   );*/
            context.SaveChanges();
        }
    }
}