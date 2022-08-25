namespace AssigmnetMvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [StringLength(10)]
        public string Username { get; set; }

        [StringLength(10)]
        public string Password { get; set; }

        public string Email { get; set; }

        public bool IsAdmin { get; set; }
    }
}
