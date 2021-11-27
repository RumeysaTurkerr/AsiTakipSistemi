using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AşıTakipSistemi.Model.Entity;


namespace AşıTakipSistemi.Model.Context
{
    class AsiTakipDbContext : DbContext
    {  
        public DbSet<cocukTable> CocukTablo { get; set; }
        public DbSet<doktorTable> DoktorTablo { get; set; }
        public DbSet<sekreterTable> SekreterTablo { get; set; }
        public DbSet<asiTable> AsiTablo { get; set; }

    }
    }

