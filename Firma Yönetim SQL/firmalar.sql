CREATE TABLE [dbo].[firmalar]
(
	OzelFirmaKodu INT NOT NULL Primary Key,
	FirmaAdi VARCHAR(50) NOT NULL,
	Onay BIT NOT NULL,
	SiparisIzin VARCHAR(1000),
	SiparisYasak VARCHAR(1000)
)