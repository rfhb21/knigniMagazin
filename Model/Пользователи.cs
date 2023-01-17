namespace knigniMagazin
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Пользователи
    {
        [Key]
        [StringLength(50)]
        public string Логин { get; set; }

        [Required]
        [StringLength(50)]
        public string Пароль { get; set; }

        [Required]
        [StringLength(50)]
        public string Фамилия { get; set; }

        [Required]
        [StringLength(50)]
        public string Имя { get; set; }

        [Required]
        [StringLength(50)]
        public string Отчество { get; set; }

        [Required]
        [StringLength(50)]
        public string НомерТелефона { get; set; }

        [Required]
        [StringLength(50)]
        public string ЭлектронныйАдрес { get; set; }

        [Column(TypeName = "date")]
        public DateTime ДатаРождения { get; set; }

        [Required]
        [StringLength(50)]
        public string Роль { get; set; }

        [Required]
        [StringLength(50)]
        public string Фото { get; set; }
    }
}
