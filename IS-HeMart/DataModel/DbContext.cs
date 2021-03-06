﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace IS_HeMart.DataModel
{
	public class HemartContext : System.Data.Entity.DbContext
	{

		public HemartContext() : base("mssql")
		{
		}

		public DbSet<Faktury> Faktury { get; set; }
		public DbSet<LiekyNaRecepte> LiekyNaRecepte { get; set; }
		public DbSet<Pacient> Pacient { get; set; }
		public DbSet<Recepty> Recepty { get; set; }
		public DbSet<TerminVysetrenia> TerminVysetrenia { get; set; }
		public DbSet<UkonyNaFakture> UkonyNaFakture { get; set; }
		public DbSet<UkonyPacienta> UkonyPacienta { get; set; }
		public DbSet<VysledkyLaboratorneVysetrenie> VysledkyLaboratorneVysetrenie { get; set; }
		public DbSet<Zamestnanec> Zamestnanec { get; set; }
		public DbSet<ZdravotnaPoistovna> ZdravotnaPoistovna { get; set; }
		public DbSet<Ziadanky> Ziadanky { get; set; }
		public DbSet<ZoznamLiekov> ZoznamLiekov { get; set; }
		public DbSet<ZoznamUkonov> ZoznamUkonov { get; set; }


		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			//Database.Log = (i) => DbLogger.Log(i);
		}
	}
}
