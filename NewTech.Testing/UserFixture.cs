using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NewTech.Controllers;
using NewTech.Core;
using NewTech.Core.Interface;
using NewTech.Core.Model;
using NewTech.Core.Repository;
using Xunit;

namespace NewTech.Testing
{
    public class UserFixture
    {
        IUserRepository _userRepository;
        [Fact]
        public void Test1()
        {
            Assert.Equal(4, Add(2, 2));
        }
        [Fact]
        public void FailingTest()
        {
            Assert.NotEqual(5, Add(2, 2));
        }
        int Add(int x, int y)
        {
            return x + y;
        }

        [Fact]
        public void GetAllUsers()
        {
            DbContextOptions<NewTechDbContext> options;
            var builder = new DbContextOptionsBuilder<NewTechDbContext>();
            builder.UseMySql("Server=sol-mysql-dev-shared.gp2.axadmin.net;database=cf_c072bcbb_3cc2_4fdb_afce_0f75a483255a; UID=4VOV802BgFWo6rul; password=QCKKXwDbzLAB0OO0;SslMode=none;old guids=true;");
            //builder.UseSqlServer("Server=TX-NKANIK-DW10\\NKANIKARAM2;Database=Manufacturer;Trusted_Connection=True;ConnectRetryCount=0");
            options = builder.Options;

            UserRepository usrRepo = new UserRepository(new NewTechDbContext(options));
            UserController usrController = new UserController(usrRepo);
            IEnumerable<User> list = usrController.GetAll();
            foreach (var item in list)
            {
                Console.WriteLine(item.UsrFirstName);
                Console.WriteLine(item.UsrLastName);
            }
            Assert.NotNull(list);
        }

        [Fact]
        public void DeleteUser()
        {
            var builder = new DbContextOptionsBuilder<NewTechDbContext>();
            builder.UseMySql("Server=sol-mysql-dev-shared.gp2.axadmin.net;database=cf_c072bcbb_3cc2_4fdb_afce_0f75a483255a; UID=4VOV802BgFWo6rul; password=QCKKXwDbzLAB0OO0;SslMode=none;old guids=true;");
            //builder.UseSqlServer("Server=TX-NKANIK-DW10\\NKANIKARAM2;Database=Manufacturer;Trusted_Connection=True;ConnectRetryCount=0");
            var options = builder.Options;

            UserRepository usrRepo = new UserRepository(new NewTechDbContext(options));
            UserController usrController = new UserController(usrRepo);
            usrController.Delete("3449FC78-C5F8-454B-AE3B-D1A8D58444C6");
        }
        [Fact]
        public void CreateUser()
        {
            User usr = new User { UsrId = "123456", UsrFirstName = "TestFirstName", UsrLastName = "TestLastName", UsrAccountName= "TestAccountName", UsrAccountPwd = "TestAccountPwd" };

            DbContextOptions<NewTechDbContext> options;
            var builder = new DbContextOptionsBuilder<NewTechDbContext>();
            builder.UseMySql("Server=sol-mysql-dev-shared.gp2.axadmin.net;database=cf_c072bcbb_3cc2_4fdb_afce_0f75a483255a; UID=4VOV802BgFWo6rul; password=QCKKXwDbzLAB0OO0;SslMode=none;old guids=true;");
            //builder.UseSqlServer("Server=TX-NKANIK-DW10\\NKANIKARAM2;Database=Manufacturer;Trusted_Connection=True;ConnectRetryCount=0");
            options = builder.Options;

            UserRepository usrRepo = new UserRepository(new NewTechDbContext(options));
            UserController usrController = new UserController(usrRepo);
            usrController.CreateUser(usr);
        }
        [Fact]
        public void UpdateManufacturer()
        {
            User usr = new User { UsrId = "123456", UsrFirstName = "TestFirstNameUpdated", UsrLastName = "TestLastNameUpdated", UsrAccountName = "TestAccountName", UsrAccountPwd = "TestAccountPwd" };

            DbContextOptions<NewTechDbContext> options;
            var builder = new DbContextOptionsBuilder<NewTechDbContext>();
            builder.UseMySql("Server=sol-mysql-dev-shared.gp2.axadmin.net;database=cf_c072bcbb_3cc2_4fdb_afce_0f75a483255a; UID=4VOV802BgFWo6rul; password=QCKKXwDbzLAB0OO0;SslMode=none;old guids=true;");
            //builder.UseSqlServer("Server=TX-NKANIK-DW10\\NKANIKARAM2;Database=Manufacturer;Trusted_Connection=True;ConnectRetryCount=0");
            options = builder.Options;

            UserRepository usrRepo = new UserRepository(new NewTechDbContext(options));
            UserController usrController = new UserController(usrRepo);
            usrController.UpdateManufacturer(usr);

        }
    }
}
