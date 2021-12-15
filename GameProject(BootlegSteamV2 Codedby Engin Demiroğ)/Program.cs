using System;

namespace GameProject_BootlegSteamV2_Codedby_Engin_Demiroğ_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Old Validation
            //GamerManager gamerManager = new GamerManager(new UserValidationManager());

            //gamerManager.Add(new Gamer
            //{
            //    Id = 1,
            //    BirthYear = 1985,
            //    FirstName = "ENGİN",
            //    LastName = "DEMİROĞ",
            //    IdentityNumber = 123456
            //});


            //New Validation
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());

            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1900,
                FirstName = "***",
                LastName = "***",
                IdentityNumber = 15
            });

        }
    }
}
