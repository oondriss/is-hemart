﻿using System;
using System.Collections.Generic;

namespace IS_HeMart.DataModel
{
	public class Zamestnanec
	{
		public int ZamestnanecID { get; set; }
		public string Login { get; set; }
		public string Heslo { get; set; }
		public DateTime Datum_narodenia { get; set; }
		public string Email { get; set; }
		public string Kod { get; set; }
		public string Meno { get; set; }
		public string Priezvisko { get; set; }
		public string Mobilne_cislo { get; set; }
		public Opravnenie Opravnenie { get; set; }
		public string Titul { get; set; }
		public string Mesto { get; set; }
		public string Ulica { get; set; }
		public string Cislo { get; set; }
		public string Psc { get; set; }
		public string Rodne_cislo { get; set; }
		public string Cislo_uctu { get; set; }
		public bool Zmazany { get; set; }
		public virtual ICollection<Pacient> ZaevidovanyPacienti { get; set; }
		public virtual ICollection<Recepty> ZaevidovaneRecepty { get; set; }
		public virtual ICollection<ZoznamLiekov> ZaevidovaneLieky { get; set; }
		public virtual ICollection<Faktury> ZaevidovaneFaktury { get; set; }
		public virtual ICollection<ZoznamUkonov> ZaevidovaneUkony { get; set; }
		public virtual ICollection<Ziadanky> ZaevidovaneZiadanky { get; set; }
		public virtual ICollection<TerminVysetrenia> ZaevidovaneVysetrenia { get; set; }
		public virtual ICollection<UkonyPacienta> ZaevidovaneUkonyPacientov { get; set; }
		public virtual ICollection<ZdravotnaPoistovna> ZaevidovaneZdravotnePoistovne { get; set; }
	}
}
