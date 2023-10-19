using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WShopApi.Model;

namespace WShopApi.Data
{
    public class WShopApiContext : DbContext
    {
        public WShopApiContext (DbContextOptions<WShopApiContext> options)
            : base(options)
        {
        }

        public DbSet<WShopApi.Model.Producto> Producto { get; set; } = default!;
    }
}
