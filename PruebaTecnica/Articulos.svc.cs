using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PruebaTecnica
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Articulos : IArticulos
    {
        
        public List<Model.Articulo> ObtenerArticulos()
        {
            ConnectionManager ConnectionManagerInstance = new ConnectionManager();
            using (IDbConnection connection = ConnectionManagerInstance.GetConnection())
            {
                var resultado = connection.Query<Model.Articulo,
                                         Model.Marca,
                                         Model.Articulo>(
                     "usp_ConsultaArticulos",
                     (articulo, marca) =>
                     {
                         articulo.Marca = (Model.Marca)marca;
                         return articulo;
                     },
                     splitOn: "IdArticulo,IdMarca",
                     commandType: CommandType.StoredProcedure);

                return resultado.Cast<Model.Articulo>().ToList();

            }
        }
    }
}
