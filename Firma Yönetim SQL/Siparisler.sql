CREATE TABLE [dbo].[Siparisler]
(
	OzelFirmaKodu INT NOT NULL Primary Key,
	OzelUrunKodu INT NOT NULL,
	SiparisTarihi VARCHAR(10) NOT NULL,
	SiparisAdedi INT NOT NULL
)
