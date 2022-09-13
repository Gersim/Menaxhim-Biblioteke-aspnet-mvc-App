using MenaxhimBibliotekeMvcApp.Models;

namespace MenaxhimBibliotekeMvcApp.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviseScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviseScope.ServiceProvider.GetService<AppDbContex>();

                context.Database.EnsureCreated();

                //Authors
                if (!context.Authors.Any())
                {
                    context.Authors.AddRange(new List<Author>()
                    {
                        new Author()
                        {
                            Name = "Zhyl",
                            LastName = "Vern",
                            Description = "Shkrimtar i shume romaneve aventurieske",
                            MotherLand = "Unknown",
                            Birthday = DateTime.Now

                        },
                        new Author()
                        {
                            Name = "Jk",
                            LastName = "Rowling",
                            Description = "Shkrimtare i shume romaneve fantazi",
                            MotherLand = "UK",
                            Birthday = DateTime.Now

                        }
                    });
                    context.SaveChanges();
                }

                //Book
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new List<Book>()
                    {
                        new Book()
                        {
                            Title = "Dy vjet Pushime",
                            Description = "Nje roman teper i bukur per femije",
                            CoverImageUrl = "https://www.theceolibrary.com/wp-content/uploads/2017/10/Two-Years-Holiday-or-Adrift-in-the-Pacific-Jules-Verne.jpg",
                            BookZhanra = Enums.BookZhanra.Adventure,
                            BookNumbers = 5,
                            BookLocation = "A",
                        },

                        new Book()
                        {
                            Title = "Harry Potter",
                            Description = "Nje roman teper i bukur per femije",
                            CoverImageUrl = "jsjsjdhsh",
                            BookZhanra = Enums.BookZhanra.Fantasy,
                            BookNumbers = 5,
                            BookLocation = "A",
                        }

                    });
                    context.SaveChanges();

                }

                //Client
                if (!context.Clients.Any())
                {
                    context.Clients.AddRange(new List<Client>()
                    {
                        new Client()
                        {
                            Name = "Ali",
                            LastName ="Baba",
                            Email = "alibaba@test.com",
                            PhoneNumber = "+355000000"
                        },
                         new Client()
                        {
                            Name = "Taulant",
                            LastName ="Hocha",
                            Email = "th@test.com",
                            PhoneNumber = "+35111111"
                        },
                          new Client()
                        {
                            Name = "Roni",
                            LastName ="Prifti",
                            Email = "rp@test.com",
                            PhoneNumber = "+3552222222"
                        }

                    });
                    context.SaveChanges();


                }

                if (!context.Author_Book.Any())
                {
                    context.Author_Book.AddRange(new List<Author_Book>()
                    {
                        new Author_Book()
                        {
                            AuthorId = 1,
                            BookId = 1
                        },
                        new Author_Book()
                        {
                            AuthorId = 2,
                            BookId = 2
                        },

                    });
                    context.SaveChanges();
                }

                //Contratct
                if (!context.Contracts.Any())
                {
                    context.Contracts.AddRange(new List<Contract>()
                    {
                        new Contract()
                        {
                            Description = "Jepet studentit",
                            BookId= 1,
                            ClientId = 2,
                            StartDate = DateTime.Now,
                            EndTime = DateTime.Now.AddDays(15)
                            

                        }
                    });
                    context.SaveChanges();

                }
            }
        }
    }
}
