using AutoMapper;
using IS_HeMart.DataModel;
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
				//cfg.CreateMap<Faktury, FakturaDTO>();
				//cfg.CreateMap<ZoznamLiekov, LiekDTO>();
				//cfg.CreateMap<LiekyNaRecepte, LiekNaRecepteDTO>();
				//cfg.CreateMap<Pacient, PacientDTO>();
				//cfg.CreateMap<ZoznamUkonov, UkonDTO>();
				//cfg.CreateMap<UkonyPacienta, UkonPacientDTO>();
				//cfg.CreateMap<Zamestnanec, ZamestnanecDTO>();
			});
		}
	}
}
