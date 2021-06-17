namespace ModelEF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserAccount")]
    public partial class UserAccount
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        [Display(Name = "Người dùng")]
        public int ID { get; set; }
       
        [StringLength(50)]
        [Display(Name = "Tên người dùng")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập tên tài khoản")]

        [StringLength(32)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }  
        [Required(ErrorMessage = "Bạn chưa nhập mật khẩu")]

        [Display(Name = "Trạng thái")]
        public bool? Status { get; set; }
    }
}
