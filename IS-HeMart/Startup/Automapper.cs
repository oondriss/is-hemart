using AutoMapper;
using IS_HeMart.DataModel;
using IS_HeMart.DataModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_HeMart.Startup
{
	public static class Automapper
	{
		public static void Configure()
		{
			Mapper.Initialize(cfg =>
			{
				cfg.CreateMap<Faktura, FakturaDTO>();
				cfg.CreateMap<Liek, LiekDTO>();
				cfg.CreateMap<LiekNaRecepte, LiekNaRecepteDTO>();
				cfg.CreateMap<Pacient, PacientDTO>();
				cfg.CreateMap<Ukon, UkonDTO>();
				cfg.CreateMap<UkonPacient, UkonPacientDTO>();
				cfg.CreateMap<Zamestnanec, ZamestnanecDTO>();
			});
		}
	}
}
