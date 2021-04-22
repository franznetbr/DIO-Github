using System;
using MongoDB.Driver.GeoJsonObjectModel;
using MongoDB.Bson;

//Classe de representação da collection no banco.
namespace Api.Data.Collections
{
    public class Infectado
    {
        public Infectado(ObjectId id, DateTime dataNascimento, string sexo, double latitude, double longitude)
        {
            this.Id = id;
            this.DataNascimento = dataNascimento;
            this.Sexo = sexo;
            this.Localizacao = new GeoJson2DGeographicCoordinates(longitude, latitude);
        }

        public ObjectId Id { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public GeoJson2DGeographicCoordinates Localizacao { get; set; }
    }
}
