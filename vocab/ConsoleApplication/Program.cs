using NinjaDomain.Classes;
using NinjaDomain.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new NullDatabaseInitializer<NinjaDomainContext>()); // No DB initialisation
            InsertClan();
            Console.ReadLine();
        }

        public static void InsertClan()
        {
            var clan = new Clan
            {
                ClanName = "Vermont Clan",
                Id = 1
            };

            using (var context = new NinjaDomainContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Clans.Add(clan);
                context.SaveChanges();
            }
        }
    }
}
