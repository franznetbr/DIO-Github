using System;
using MongoDB.Bson;

namespace Mongo_DIO.Models
{
    public class InfectadoDto
    {
        public ObjectId Id { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}