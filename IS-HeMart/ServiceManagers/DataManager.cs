using AutoMapper;
using IS_HeMart.DataModel;
using IS_HeMart.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Equin.ApplicationFramework;
using System.Collections.ObjectModel;

namespace IS_HeMart.ServiceManagers
{
	public class DataManager
	{
		private static HemartContext ctx = null;

		private HemartContext GetContext()
		{
			if (ctx == null)
			{
				ctx = new HemartContext();
				return ctx;
			}
			return ctx;
		}

		//public BindingList<ZoznamUkonov> GetUkonyBindingSource()
		//{
		//	var data = GetContext();
		//	data.ZoznamUkonov.Load();
		//	return data.ZoznamUkonov.Local.ToBindingList();
		//}

		public ZoznamLiekovDTO UpdateLiekWithDescription(ZoznamLiekovDTO liek)
		{
			liek.Nazov = liek.Sukl_kod + "- " + liek.Nazov;
			return liek;
		}

		public List<ZoznamLiekovDTO> GetLiekyDescBindingSource()
		{
			var data = GetContext();
			return data.ZoznamLiekov.ToList().Select(i => new ZoznamLiekovDTO(i)).Select(i => UpdateLiekWithDescription(i)).ToList();
		}

		internal ZoznamUkonov GetZoznamUkonovById(int selectedValue)
		{
			var data = GetContext();
			return data.ZoznamUkonov.Single(i => i.ZoznamUkonovID == selectedValue);
		}

		internal BindingList<ZoznamUkonov> GetUkonyBindingSource()
		{
			var data = GetContext();
			data.ZoznamUkonov.Load();
			return data.ZoznamUkonov.Local.ToBindingList();
		}

		public BindingList<ZoznamLiekov> GetZoznamLiekovBindingSource()
		{
			var data = GetContext();
			data.ZoznamLiekov.Load();
			return data.ZoznamLiekov.Local.ToBindingList();
		}

		public BindingList<ZdravotnaPoistovna> GetPoistovneBindingSource()
		{
			var data = GetContext();
			data.ZdravotnaPoistovna.Load();
			return data.ZdravotnaPoistovna.Local.ToBindingList();
		}

		public BindingList<TerminVysetrenia> GetTerminyBindingSource()
		{
			var data = GetContext();
			data.TerminVysetrenia.Load();
			return data.TerminVysetrenia.Local.ToBindingList();
		}

		public BindingList<Recepty> GetReceptyBindingSource()
		{
			var data = GetContext();
			data.Recepty.Load();
			return data.Recepty.Local.ToBindingList();
		}

		public BindingList<Ziadanky> GetZiadankyBindingSource()
		{
			var data = GetContext();
			data.Ziadanky.Load();
			return data.Ziadanky.Local.ToBindingList();
		}

		internal ZoznamLiekov GetZoznamLiekovById(int selectedValue)
		{
			var data = GetContext();
			return data.ZoznamLiekov.First(i => i.ZoznamLiekovID == selectedValue);
		}

		public BindingList<Pacient> GetPacientBindingSource()
		{
			var data = GetContext();
			data.Pacient.Load();
			return data.Pacient.Local.ToBindingList();
		}

		public BindingList<ZoznamUkonov> GetZoznamUkonovBindingSource(Pacient pacient)
		{
			//var data = GetContext();
			//data.ZoznamUkonov.Load();
			//return data.ZoznamUkonov.Local.ToBindingList();



			var data = GetContext();
			var items = data.UkonyPacienta.Where(i => i.Pacient.PacientID == pacient.PacientID)/*.OrderBy(i => i.Datum)*/.Select(i => i.Ukon).ToList();
			var obc = new ObservableCollection<ZoznamUkonov>(items);
			return obc.ToBindingList();
		}

		public IQueryable<TerminVysetrenia> GetTerminy()
		{
			return GetContext()
					.TerminVysetrenia;
		}

		public IQueryable<ZoznamUkonov> GetUkony()
		{
			return GetContext()
					.ZoznamUkonov;
		}

		public IQueryable<ZdravotnaPoistovna> GetPoistovne()
		{
			return GetContext()
					.ZdravotnaPoistovna;
		}

		public BindingList<VysledkyLaboratorneVysetrenie> GetVysledkyBindingSource()
		{
			var data = GetContext();
			data.VysledkyLaboratorneVysetrenie.Load();
			return data.VysledkyLaboratorneVysetrenie.Local.ToBindingList();
		}

		//public List<ZamestnanecDTO> GetZamestnanecDTO()
		//{
		//	var dat = GetContext()
		//				.Zamestnanec
		//				.ToList();
		//	return dat.Select(i => Mapper.Map<ZamestnanecDTO>(i)).ToList();
		//}

		public IQueryable<Recepty> GetPacientRecept(Pacient pacient)
		{
			return GetContext()
					.Recepty
					.Where(i => i.Pacient == pacient);
		}

		public BindingList<Faktury> GetFakturyBindingList()
		{
			var data = GetContext();
			data.Faktury.Load();
			return data.Faktury.Local.ToBindingList();
		}

		public IQueryable<Faktury> GetFaktury()
		{
			return GetContext()
					.Faktury;
		}

		//public ZamestnanecDTO GetZamestnanecDTO(int ID)
		//{
		//	return GetContext()
		//			.Zamestnanec
		//			.Where(i => i.ZamestnanecID == ID)
		//			.Select(i => Mapper.Map<ZamestnanecDTO>(i))
		//			.SingleOrDefault();
		//}

		public IQueryable<Ziadanky> GetPacientZiadanky(Pacient pacient)
		{
			return GetContext()
					.Ziadanky
					.Where(i => i.Pacient == pacient);
		}

		public IQueryable<UkonyPacienta> GetPacientUkony(Pacient pacient)
		{
			return GetContext()
					.UkonyPacienta
					.Where(i => i.Pacient == pacient);
		}

		public BindingList<Zamestnanec> GetZamestnanecBindingSource()
		{
			var data = GetContext();
			data.Zamestnanec.Load();
			return data.Zamestnanec.Local.ToBindingList();
		}

		public Zamestnanec GetZamestnanec(int ID)
		{
			return GetContext()
					.Zamestnanec
					.Where(i => i.ZamestnanecID == ID)
					.SingleOrDefault();
		}

		//public bool InsertZamestnanec(ZamestnanecDTO item)
		//{

		//	var newItem = GetContext().Zamestnanec.Add(new Zamestnanec()
		//	{
		//		Cislo = item.Cislo,
		//		Meno = item.Meno,
		//		Mesto = item.Mesto,
		//		Priezvisko = item.Priezvisko,
		//		Psc = item.Psc,
		//		Ulica = item.Ulica,
		//		Zmazany = item.Zmazany
		//	});

		//	return newItem == null ? false : true;
		//}

		//public List<PacientDTO> GetPacient()
		//{
		//	return GetContext()
		//			.Pacient
		//			.ToList()
		//			.Select(i => Mapper.Map<PacientDTO>(i))
		//			.ToList();
		//}

		public Pacient GetPacient(int ID)
		{
			return GetContext()
					.Pacient
					.Where(i => i.PacientID == ID)
					.SingleOrDefault();
		}

		public Zamestnanec AuthorizeNamePass(string name, string pass)
		{
			var encPassword = ShaEncrypter.Hash(pass);
			var data = GetContext();
			if (data.Zamestnanec.Any(i => i.Login == name && i.Heslo == encPassword))
			{
				return data.Zamestnanec.First(i => i.Login == name && i.Heslo == encPassword);
			}
			return null;
		}

		public IQueryable<ZoznamUkonov> GetZoznamUkonov()
		{
			return GetContext()
					.ZoznamUkonov;
		}

		public IQueryable<ZoznamLiekov> GetZoznamLiekov()
		{
			return GetContext()
					.ZoznamLiekov;
		}

		public IQueryable<ZoznamLiekov> GetZoznamLiekov(string searchValue)
		{
			if (string.IsNullOrWhiteSpace(searchValue))
			{
				return GetZoznamLiekov();
			}
			return GetContext()
					.ZoznamLiekov
					.Where(i => i.Nazov.Contains(searchValue) ||
							   i.Sukl_kod.Contains(searchValue) ||
							   i.Doplnok.Contains(searchValue));
		}

		public DbContext GetDbContext()
		{
			return GetContext();
		}

		public void AddNewPacient(Pacient newPacient)
		{
			var data = GetContext();
			data.Pacient.Add(newPacient);
			data.SaveChanges();
		}

		public ZdravotnaPoistovna GetPoistovnaById(int poistovnaId)
		{
			var data = GetContext();
			return data.ZdravotnaPoistovna.Single(i => i.ZdravotnaPoistovnaID == poistovnaId);
		}

		//public bool InsertPacient(PacientDTO item)
		//{

		//	var newItem = GetContext().Pacient.Add(new Pacient()
		//	{
		//		Cislo = item.Cislo,
		//		Meno = item.Meno,
		//		Mesto = item.Mesto,
		//		Priezvisko = item.Priezvisko,
		//		PSC = item.PSC,
		//		Ulica = item.Ulica,
		//		Zmazany = item.Zmazany,
		//		DatumNarodenia = item.DatumNarodenia,
		//		DatumVytvorenia = item.DatumVytvorenia,
		//		EvidujuciZamestnanec = item.EvidujuciZamestnanec,
		//		RodneCislo = item.RodneCislo
		//	});
		//	GetContext().SaveChanges();
		//	return newItem == null ? false : true;
		//}
	}
}
