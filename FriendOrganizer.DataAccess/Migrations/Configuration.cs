namespace FriendOrganizer.DataAccess.Migrations
{
    using FriendOrganizer.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizer.DataAccess.FriendOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganizer.DataAccess.FriendOrganizerDbContext context)
        {
            context.Friends.AddOrUpdate(
                f => f.FirstName,
                new Friend { FirstName = "Thomas", LastName = "Preiksaitis", Email="tpreiksaitis@gmail.com" },
                new Friend { FirstName = "Andreas", LastName = "Boehler", Email = "aboehler@gmail.com" },
                new Friend { FirstName = "Julia", LastName = "Huber", Email = "jhuber@gmail.com" },
                new Friend { FirstName = "Chrissi", LastName = "Egin", Email = "cegin@gmail.com" }
                );
        }
    }
}
