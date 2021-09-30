using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

[Table("News")]
public partial class News
{
    [Key]
    public int ID { get; set; }

    [Required(ErrorMessage = "Yêu cầu nhập tiêu đề")]
    [StringLength(1000)]
    public string Title { get; set; }

    [Required]
    [Column(TypeName = "ntext")]
    public string Brief { get; set; }
}
