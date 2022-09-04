using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

    public class Resource
    {
        [Key]
        public int ID { get; set; }


        [NotNull]
        [Required(ErrorMessage = "Необходимо указать наименование ресурса")]
        public string Name { get; set; }

        [NotNull]
        [Required(ErrorMessage = "Необходимо ввести задать тип ресурса (MimeType)")]
        public string Mime { get; set; }


        [NotNull]
        [Required(ErrorMessage = "Необходимо ввести бинарные данные ресурса")]
        public byte[] Data { get; set; }


        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Необходимо указать время создания ресурса")]
        public DateTime Created { get; set; }

    }
