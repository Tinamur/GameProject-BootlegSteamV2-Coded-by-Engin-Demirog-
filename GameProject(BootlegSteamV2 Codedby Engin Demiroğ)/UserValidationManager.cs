using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_BootlegSteamV2_Codedby_Engin_Demiroğ_
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear ==1985 && gamer.FirstName=="ENGİN"
                && gamer.LastName == "DEMİROĞ" && gamer.IdentityNumber == 123456)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
