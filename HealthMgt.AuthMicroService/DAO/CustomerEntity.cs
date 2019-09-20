using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthMgt.AuthMicroService.DAO
{
    [Table("Customer")]
    public class CustomerEntity
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public AppUserEntity Identity { get; set; }  // navigation property
        public string Location { get; set; }
        public string Locale { get; set; }
        public string Gender { get; set; }
    }
}
