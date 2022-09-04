using ApplicationCommon.CommonTypes;

using ApplicationDb.Types;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationCommon.CommonResources
{
    /// <summary>
    /// Модель файлового каталога
    /// </summary>
    public class FileCatalog : HierDictionaryTable<FileCatalog>
    {

        public FileCatalog()
        {
            Files = new List<FileResource>();
        }

        public FileCatalog(string name)
        {
            Files = new List<FileResource>();
            Name = name;
        }

        [Key]
        public int ID { get; set; }

        public virtual List<FileResource> Files { get; set; }
    }
}
