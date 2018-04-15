﻿using AutoMapper;
using IS_HeMart.DataModel;
using IS_HeMart.DataModel.DTO;
using IS_HeMart.Utils;
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
						.Zamestnanec
						.ToList();
			return dat.Select(i => Mapper.Map<ZamestnanecDTO>(i)).ToList();
		}

		public ZamestnanecDTO GetZamestnanecDTO(int ID)
		{
			return GetContext()
					.Zamestnanec
					.Where(i => i.ZamestnanecID == ID)
					.Select(i => Mapper.Map<ZamestnanecDTO>(i))
					.SingleOrDefault();
		}

		public List<Zamestnanec> GetZamestnanec()
		{
			return GetContext()
					.Zamestnanec
					.ToList();
		}

		public Zamestnanec GetZamestnanec(int ID)
		{
			return GetContext()
					.Zamestnanec
					.Where(i => i.ZamestnanecID == ID)
					.SingleOrDefault();
		}

		public bool InsertZamestnanec(ZamestnanecDTO item)
		{

			var newItem = GetContext().Zamestnanec.Add(new Zamestnanec()
			{
				Cislo = item.Cislo,
				Meno = item.Meno,
				Mesto = item.Mesto,
				Priezvisko = item.Priezvisko,
				Psc = item.PSC,
				Ulica = item.Ulica,
				Zmazany = item.Zmazany
			});

			return newItem == null ? false : true;
		}

		public List<PacientDTO> GetPacient()
		{
			return GetContext()
					.Pacient
					.ToList()
					.Select(i => Mapper.Map<PacientDTO>(i))
					.ToList();
		}

		public PacientDTO GetPacient(int ID)
		{
			return GetContext()
					.Pacient
					.Where(i => i.PacientID == ID)
					.Select(i => Mapper.Map<PacientDTO>(i))
					.SingleOrDefault();
		}

		public ZamestnanecDTO AuthorizeNamePass(string name, string pass)
		{
			var encPassword = ShaEncrypter.Hash(pass);
			if (GetContext().Zamestnanec.Any(i => i.Login == name && i.Heslo == encPassword))
			{
				return Mapper.Map<ZamestnanecDTO>(GetContext().Zamestnanec.First(i => i.Login == name && i.Heslo == encPassword));
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

		public bool InsertPacient(PacientDTO item)
		{

			var newItem = GetContext().Pacient.Add(new Pacient()
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
