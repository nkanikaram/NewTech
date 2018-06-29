using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using NewTech.Core.Model;

namespace NewTech.Core
{
    public class DbInitializer
    {
        public static List<User> GetUserSampleData()
        {
            // Add Users
            var usr1 = new User { UsrId = "Id1", UsrFirstName = "FName1", UsrLastName = "LName1", UsrAccountName = "Test1", UsrAccountPwd = "pwd1" };
            var usr2 = new User { UsrId = "Id2", UsrFirstName = "FName2", UsrLastName = "LName1", UsrAccountName = "Test2", UsrAccountPwd = "pwd2" };
            var usr3 = new User { UsrId = "Id3", UsrFirstName = "FName3", UsrLastName = "LName1", UsrAccountName = "Test3", UsrAccountPwd = "pwd3" };
            var usr4 = new User { UsrId = "Id4", UsrFirstName = "FName4", UsrLastName = "LName1", UsrAccountName = "Test4", UsrAccountPwd = "pwd4" };
            var usr5 = new User { UsrId = "Id5", UsrFirstName = "FName5", UsrLastName = "LName1", UsrAccountName = "Test5", UsrAccountPwd = "pwd5" };
            var usr6 = new User { UsrId = "Id6", UsrFirstName = "FName6", UsrLastName = "LName1", UsrAccountName = "Test6", UsrAccountPwd = "pwd6" };
            var usr7 = new User { UsrId = "Id7", UsrFirstName = "FName7", UsrLastName = "LName1", UsrAccountName = "Test7", UsrAccountPwd = "pwd7" };
            var usr8 = new User { UsrId = "Id8", UsrFirstName = "FName8", UsrLastName = "LName1", UsrAccountName = "Test8", UsrAccountPwd = "pwd8" };
            var usr9 = new User { UsrId = "Id9", UsrFirstName = "FName9", UsrLastName = "LName1", UsrAccountName = "Test9", UsrAccountPwd = "pwd9" };
            var usr10 = new User { UsrId = "Id10", UsrFirstName = "FName10", UsrLastName = "LName10", UsrAccountName = "Test10", UsrAccountPwd = "pwd10" };

            List<User> list = new List<User> { usr1, usr2, usr3, usr4, usr5, usr6, usr7, usr8, usr9, usr10 };
            return list;
        }
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<NewTechDbContext>();
                // Add Users
                var usr1 = new User { UsrId = "Id1", UsrFirstName = "FName1", UsrLastName = "LName1", UsrAccountName = "Test1", UsrAccountPwd = "pwd1" };
                var usr2 = new User { UsrId = "Id2", UsrFirstName = "FName2", UsrLastName = "LName1", UsrAccountName = "Test2", UsrAccountPwd = "pwd2" };
                var usr3 = new User { UsrId = "Id3", UsrFirstName = "FName3", UsrLastName = "LName1", UsrAccountName = "Test3", UsrAccountPwd = "pwd3" };
                var usr4 = new User { UsrId = "Id4", UsrFirstName = "FName4", UsrLastName = "LName1", UsrAccountName = "Test4", UsrAccountPwd = "pwd4" };
                var usr5 = new User { UsrId = "Id5", UsrFirstName = "FName5", UsrLastName = "LName1", UsrAccountName = "Test5", UsrAccountPwd = "pwd5" };
                var usr6 = new User { UsrId = "Id6", UsrFirstName = "FName6", UsrLastName = "LName1", UsrAccountName = "Test6", UsrAccountPwd = "pwd6" };
                var usr7 = new User { UsrId = "Id7", UsrFirstName = "FName7", UsrLastName = "LName1", UsrAccountName = "Test7", UsrAccountPwd = "pwd7" };
                var usr8 = new User { UsrId = "Id8", UsrFirstName = "FName8", UsrLastName = "LName1", UsrAccountName = "Test8", UsrAccountPwd = "pwd8" };
                var usr9 = new User { UsrId = "Id9", UsrFirstName = "FName9", UsrLastName = "LName1", UsrAccountName = "Test9", UsrAccountPwd = "pwd9" };
                var usr10 = new User { UsrId = "Id10", UsrFirstName = "FName10", UsrLastName = "LName10", UsrAccountName = "Test10", UsrAccountPwd = "pwd10" };

                context.Users.Add(usr1);
                context.Users.Add(usr2);
                context.Users.Add(usr3);
                context.Users.Add(usr4);
                context.Users.Add(usr5);
                context.Users.Add(usr6);
                context.Users.Add(usr7);
                context.Users.Add(usr8);
                context.Users.Add(usr9);
                context.Users.Add(usr10);
                context.SaveChanges();
            }
        }
    }
}
