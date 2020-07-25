using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PruebaTecnica.Model
{
    [DataContract]
    public class Articulo
    {
        [DataMember]
        public int IdArticulo { get; set; }
        [DataMember]
        public string Descripcion    { get; set; }
        [DataMember]
        public int Sku{ get; set; }
        [DataMember]
        public decimal cantidad { get; set; }
        [DataMember]
        public Marca Marca { get; set; }

    }
}