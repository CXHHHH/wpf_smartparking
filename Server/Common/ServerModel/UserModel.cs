using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerModel
{
    [Table("sys_user")]
    public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("user_name")]
        public string UserName { get; set; }

        [Column("password")]
        public string PassWord { get; set; }

        [Column("user_icon")]
        public string UserIcon { get; set; }

        [Column("real_name")]
        public string RealName { get; set; }

        [Column("age")]
        public int Age { get; set; }

        [DefaultValue(1)]
        public int State { get; set; }


    }
}
