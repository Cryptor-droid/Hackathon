using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.Swagger;
using System;
using System.Linq;

namespace Yarısma
{
    public class Firma
    {
        public int FirmaID { get; set; }
        public string FirmaAdi { get; set; }
        public bool FirmaOnay { get; set; }

        public string SerbestSaatler { get; set; }

        public string YasaklıSaatler { get; set; }
    }
    public class Siparis
    {
        public int FirmaID { get; set; }
        public int UrunID { get; set; }
        public int UrunAdedi { get; set; }
        public string SiparişTarihi { get; set; }
    }
    public class Urun
    {
        public int UrunID { get; set; }
        public string UrunIsmi { get; set; }

    }
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
    public class SwaggerParameterAttribute : Attribute
    {
        public SwaggerParameterAttribute(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; private set; }
        public Type DataType { get; set; }
        public string ParameterType { get; set; }
        public string Description { get; private set; }
        public bool Required { get; set; } = false;
    }
}
