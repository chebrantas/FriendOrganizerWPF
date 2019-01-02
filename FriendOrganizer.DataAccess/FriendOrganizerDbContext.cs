using FriendOrganizer.DataAccess.EntityConfiguration;
using FriendOrganizer.Model;
using System;
using System.Data.Entity;

using System.Data.Entity.ModelConfiguration.Conventions;
using System.IO;

namespace FriendOrganizer.DataAccess
{
    public class FriendOrganizerDbContext:DbContext
    {
        public FriendOrganizerDbContext():base("FriendOrganizerDb")
        {
            //reikalinga eilute, kad nemestu klaidos nurodo kur DB failiuka issaugoti cia po Update-Database komandos
            //Db failas saugomas C://User/LocalData/Local..
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\FriendOrganizerData"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\FriendOrganizerData");
            }
            AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\FriendOrganizerData");
        }
                
        public DbSet<Friend> Friends { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new FriendConfiguration());


            //perkeltas i configuration faila
            //modelBuilder.Entity<Friend>()
            //    .Property(f => f.FirstName)
            //    .IsRequired()
            //    .HasMaxLength(50);
        }
        //kad igalinti Migration reikalingos komandos per NugetPackage comandline:
        //Enable-Migrations ir pasirenkama Default project>>>Tada atsiranda Migrations katalogas
        //po to i SEED surasome duomenis ir seka kitos komandos i NugetPackage comandline:
        //Add-Migration InitialDatabase; cia automatiskai Db nera perkuriama kaip MVC todel pakeitus model reikia vis 
        //paleisti komanda Add-Migration InitialDatabase
        //antra kart sita komanda gali reikalauti naudoti -Force atributa:
        //Add-Migration -Force
        //Tada naudojama komanda:
        //Update-Database -StartUpProjectName bet mums reikia connectionString ideti i pradzios projecta kuris yra 
        //FriendOrganizer.UI nes pradzios projekte App.config ieskos connectionStringo, taigi is .DataAccess projekto
        //nukopinam connectionString i .UI projekta
        //kadangi perkopinome connectionStringa i .UI uztenka naudoti komanda:
        //Update-Database be jokiu atributu
    }

}
