using AutoMapper;
using IS_HeMart.DataModel;
using IS_HeMart.DataModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IS_HeMart.ServiceManagers
{
	public class DataManager
	{
		private static DbContext ctx = null;

		private DbContext GetContext()
		{
			if (ctx == null)
			{
				ctx = new DbContext();
				return ctx;
			}
			return ctx;
		}

		public List<ZamestnanecDTO> GetZamestnanecDTO()
		{
			var dat = GetContext()
						.Zamestnaneci
						.ToList();
			return dat.Select(i => Mapper.Map<ZamestnanecDTO>(i)).ToList();
		}

		public ZamestnanecDTO GetZamestnanecDTO(int ID)
		{
			return GetContext()
					.Zamestnaneci
					.Where(i => i.ZamestnanecID == ID)
					.Select(i => Mapper.Map<ZamestnanecDTO>(i))
					.SingleOrDefault();
		}

		public List<Zamestnanec> GetZamestnanec()
		{
			return GetContext()
					.Zamestnaneci
					.ToList();
		}

		public Zamestnanec GetZamestnanec(int ID)
		{
			return GetContext()
					.Zamestnaneci
					.Where(i => i.ZamestnanecID == ID)
					.SingleOrDefault();
		}

		public bool InsertZamestnanec(ZamestnanecDTO item)
		{

			var newItem = GetContext().Zamestnaneci.Add(new Zamestnanec()
			{
				Cislo = item.Cislo,
				Meno = item.Meno,
				Mesto = item.Mesto,
				Priezvisko = item.Priezvisko,
				PSC = item.PSC,
				Ulica = item.Ulica,
				Zmazany = item.Zmazany
			});

			return newItem == null ? false : true;
		}

		public List<PacientDTO> GetPacient()
		{
			return GetContext()
					.Pacienti
					.ToList()
					.Select(i => Mapper.Map<PacientDTO>(i))
					.ToList();
		}

		public PacientDTO GetPacient(int ID)
		{
			return GetContext()
					.Pacienti
					.Where(i => i.PacientID == ID)
					.Select(i => Mapper.Map<PacientDTO>(i))
					.SingleOrDefault();
		}

		public ZamestnanecDTO AuthorizeNamePass(string name, string pass)
		{
			if (GetContext().Zamestnaneci.Any(i => i.Meno == name && i.Cislo == pass))
			{
				return Mapper.Map<ZamestnanecDTO>(GetContext().Zamestnaneci.First(i => i.Meno == name && i.Cislo == pass));
			}
			return null;
		}

		public bool InsertPacient(PacientDTO item)
		{

			var newItem = GetContext().Pacienti.Add(new Pacient()
			{
				Cislo = item.Cislo,
				Meno = item.Meno,
				Mesto = item.Mesto,
				Priezvisko = item.Priezvisko,
				PSC = item.PSC,
				Ulica = item.Ulica,
				Zmazany = item.Zmazany,
				DatumNarodenia = item.DatumNarodenia,
				DatumVytvorenia = item.DatumVytvorenia,
				EvidujuciZamestnanec = item.EvidujuciZamestnanec,
				RodneCislo = item.RodneCislo
			});
			GetContext().SaveChanges();
			return newItem == null ? false : true;
		}
	}
}
