SET IDENTITY_INSERT ZdravotnaPoistovna ON
insert into ZdravotnaPoistovna(ZdravotnaPoistovnaID, Nazov, Mesto, Ulica,Psc,Cislo,ICO, DIC, IC_DPH, CisloUctu, Zamestnanec_ZamestnanecID) values (1,'VSZP','Trnava','Hlavna','81701','1','21104837','12345678','SK12345678','21024426782545/2202',1);
SET IDENTITY_INSERT ZdravotnaPoistovna OFF
SET IDENTITY_INSERT faktury ON
insert into faktury(FakturyID, DatumVystavenia, DatumSplatnosti, KonSymbol, VarSymbol, Poistovna_ZdravotnaPoistovnaID, Vystavil_ZamestnanecID)  values (1,'2018-04-15','2018-05-15','001','002',1,1);
SET IDENTITY_INSERT faktury OFF