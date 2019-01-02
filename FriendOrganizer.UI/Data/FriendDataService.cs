using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;
using System.Collections.Generic;
using System.Linq;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {

            using(var ctx=new FriendOrganizerDbContext())
            {
                return ctx.Friends.AsNoTracking().ToList();
            }
            ////TODO: Load data from real database
            //yield return new Friend { FirstName = "Thomas", LastName = "Preiksaitis" };
            //yield return new Friend { FirstName = "Andreas", LastName = "Boehler" };
            //yield return new Friend { FirstName = "Julia", LastName = "Huber" };
            //yield return new Friend { FirstName = "Chrissi", LastName = "Egin" };
        }
    }
}
