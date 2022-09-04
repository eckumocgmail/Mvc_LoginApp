using ApplicationCommon.CommonResources;
using ApplicationCommon.CommonServices.CommonResources;

using Microsoft.EntityFrameworkCore;

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;


public partial class ResourcesDbContext : DbContext
{
    
    public virtual DbSet<FileCatalog> FileCatalogs { get; set; }
    public virtual DbSet<FileResource> FileResources { get; set; }

    public ResourcesDbContext()
    {
    }

    public ResourcesDbContext([NotNullAttribute] DbContextOptions<ResourcesDbContext> options) : base(options)
    {
    }
}
