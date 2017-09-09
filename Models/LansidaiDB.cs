using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LanSiDai.Models
{
    public class LansidaiDB:DbContext
    {
        public DbSet<Questions> Questions { get; set; }
    }
}