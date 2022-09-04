using ApplicationCommon.CommonTypes;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationCommon.CommonResources
{
    public class FileResource: TypeFile
    {

        public FileResource(){}
        public FileResource(TypeFile file)
        {
            Mime = file.Mime;
            Name = file.Name;
            Data = file.Data;
            Changed = file.Changed;
        }


        [Key]
        public int ID { get; set; }
        
        
        public int CatalogID { get; set; }
        public FileCatalog Catalog { get; set; }
        
    }
}
