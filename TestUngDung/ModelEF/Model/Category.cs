namespace ModelEF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Danh mục")]
        public int CategoryID { get; set; }

        [StringLength(250)]
        [Display(Name = "Tên danh mục")]
        public string Name { get; set; }

        [StringLength(250)]
        [Display(Name = "Mô tả")]
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
