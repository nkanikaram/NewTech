using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewTech.Core.Model
{
    public class User
    {
        [Key]
        public string UsrId { get; set; }
        public string UsrFirstName { get; set; }
        public string UsrLastName { get; set; }
        public string UsrAccountName { get; set; }
        public string UsrAccountPwd { get; set; }
    }
}
