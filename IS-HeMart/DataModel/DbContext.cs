using IS_HeMart.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.DataModel
{
	public class DbContext : System.Data.Entity.DbContext
	{

		public DbContext() : base("mssql")
		{
		}

		public DbSet<Faktura> Faktury { get; set; }
		public DbSet<Liek> Liek { get; set; }
		public DbSet<LiekNaRecepte> LiekyNaReceptoch { get; set; }
		public DbSet<Pacient> Pacienti { get; set; }
		public DbSet<Recept> Recepty { get; set; }
		public DbSet<Ukon> Ukony { get; set; }
		public DbSet<UkonPacient> UkonyPacientov { get; set; }
		public DbSet<Zamestnanec> Zamestnaneci { get; set; }


		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			//Database.Log = (i) => DbLogger.Log(i);
		}
	}
}
