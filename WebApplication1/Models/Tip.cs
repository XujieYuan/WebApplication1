namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tip
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Img_src { get; set; }

        [Required]
        public string Content { get; set; }

        public int House_categeryId { get; set; }

        public string Description { get; set; }

        public virtual House_category House_category { get; set; }
    }
}
