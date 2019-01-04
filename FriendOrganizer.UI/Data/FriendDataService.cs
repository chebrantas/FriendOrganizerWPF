using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        private Func<FriendOrganizerDbContext> _contextCreator;

        public FriendDataService(Func<FriendOrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }


        public async Task<Friend> GetByIdAsync(int friendId)
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Friends.AsNoTracking().SingleAsync(f => f.FriendId == friendId);
            }
        }
        //public async Task<List<Friend>> GetAllAsync()
        //{

        //    using (var ctx = _contextCreator())
        //    {
        //        return await ctx.Friends.AsNoTracking().ToListAsync();

        //        //var friends = await ctx.Friends.AsNoTracking().ToListAsync();
        //        //await Task.Delay(5000);
        //        //return friends;
        //    }


        //    //using (var ctx = new FriendOrganizerDbContext())
        //    //{
        //    //    return ctx.Friends.AsNoTracking().ToList();
        //    //}
        //    ////TODO: Load data from real database
        //    //yield return new Friend { FirstName = "Thomas", LastName = "Preiksaitis" };
        //    //yield return new Friend { FirstName = "Andreas", LastName = "Boehler" };
        //    //yield return new Friend { FirstName = "Julia", LastName = "Huber" };
        //    //yield return new Friend { FirstName = "Chrissi", LastName = "Egin" };
        //}


        //be async kaip atrode
        //public IEnumerable<Friend> GetAll()
        //{

        //    using (var ctx = _contextCreator())
        //    {
        //        //return await ctx.Friends.AsNoTracking().ToListAsync();

        //        var friends = ctx.Friends.AsNoTracking().ToList();
        //        Task.Delay(15000);
        //        return friends;
        //    }
        //}
    }
}
