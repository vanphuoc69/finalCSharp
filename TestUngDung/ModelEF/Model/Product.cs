namespace ModelEF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name="Mã sản phẩm")]
        public int ID { get; set; }

        [Display(Name = "Danh mục")]
        public int? CategoryID { get; set; }

        [StringLength(250)]
        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; }

        [Display(Name = "Đơn giá")]
        public decimal? UnitCost { get; set; }
        [Range(0, Int32.MaxValue, ErrorMessage = "Bạn phải nhập số.")]

        [Display(Name = "Số lượng")]
        public int? Quantity { get; set; }


        [StringLength(250)]
        [Display(Name = "Hình ảnh")]
        public string Image { get; set; }

        [StringLength(500)]
        [Display(Name = "Mô tả")]
        public string Description { get; set; }

        [Display(Name = "Trạng thái")]
        public bool? Status { get; set; }
        public virtual Category Category { get; set; }
    }
}
