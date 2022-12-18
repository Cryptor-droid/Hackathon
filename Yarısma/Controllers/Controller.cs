using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
//Server=localhost;Database=master;Trusted_Connection=True;
namespace Yarısma.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FirmaController : ControllerBase
    {

        private readonly ILogger<Controller> _Firmalogger;

        public FirmaController(ILogger<Controller> Firmalogger)
        {
            _Firmalogger = Firmalogger;
        }

        [HttpGet]
        public IEnumerable<Firma> Get() //Bu fonksiyon kullanılarak veritabanına bir adet firma eklenebilir.
        {
            List<Firma> ret_value = new List<Firma>();
            Random rand = new Random();
            for (int i = 0; i < rand.Next(10)+ 1; i++)
            {
                Firma firma = new Firma();
                firma.FirmaID = rand.Next(100);
                firma.FirmaOnay = rand.Next(2) == 1;
                firma.FirmaAdi = "Firma numara : " + rand.Next(100).ToString();
                firma.SerbestSaatler = RandomDayFunc().ToString("t");
                firma.YasaklıSaatler = RandomDayFunc().ToString("t");
                ret_value.Add(firma);
            }
            return ret_value;
        }

        DateTime RandomDayFunc()
        {
            DateTime start = new DateTime(1995, 1, 1);
            Random gen = new Random();
            int range = ((TimeSpan)(DateTime.Today - start)).Days;
            return start.AddDays(gen.Next(range)).AddMinutes(gen.Next(range));
        }

        [HttpDelete]
        public void Delete()
        {
            //Bu fonksiyon kullanılarak veritabanından bir adet firma silinebilir.
        }
    }
    [ApiController]
    [Route("[controller]")]
    public class UrunController : ControllerBase
    {

        private readonly ILogger<Controller> _Urunlogger;

        public UrunController(ILogger<Controller> Urunlogger)
        {
            _Urunlogger = Urunlogger;
        }

        [HttpGet]
        public IEnumerable<Urun> Get() //Bu fonksiyon kulanılarak veritabanına bir adet ürün yazılabilir.
        {
            List<Urun> ret_value = new List<Urun>();
            Random rand = new Random();
            for (int i = 0; i < rand.Next(10)+1; i++)
            {
                Urun ürün = new Urun();
                ürün.UrunID = rand.Next(100);
                ürün.UrunIsmi = "Urun numara : " + rand.Next(10).ToString();
                ret_value.Add(ürün);
            }
            return ret_value;
        }
        [HttpDelete]
        public void Delete()
        {
            //Bu fonksiyon kulanılarak veritabanından bir adet ürün silinebilir.
        }
    }
    [ApiController]
    [Route("[controller]")]
    public class SiparisController : ControllerBase
    {

        private readonly ILogger<Controller> _Siparislogger;

        public SiparisController(ILogger<Controller> Siparislogger)
        {
            _Siparislogger = Siparislogger;
        }

        [HttpGet]
        public IEnumerable<Siparis> Get() //Bu fonksiyon kullanılarak veritabanına bir sipariş yazılabilir.
        {
            List<Siparis> ret_value = new List<Siparis>();
            Random rand = new Random();
            for (int i = 0; i < rand.Next(10)+1; i++)
            {
                Siparis siparis = new Siparis();
                siparis.FirmaID = rand.Next(100);
                siparis.SiparişTarihi = RandomDayFunc().ToString("F");
                siparis.UrunAdedi = rand.Next(20);
                siparis.UrunID = rand.Next(100);
                ret_value.Add(siparis);
            }
            return ret_value;
        }
        [HttpDelete]
        public void Delete()
        {
            // Bu fonksiyonu kullanarak veritabanındaki bir siparişi silebiliriz.
        }
        DateTime RandomDayFunc()
        {
            DateTime start = new DateTime(1995, 1, 1);
            Random gen = new Random();
            int range = ((TimeSpan)(DateTime.Today - start)).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}
