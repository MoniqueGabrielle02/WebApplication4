using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class CachorroModel
    {
        public string Raça { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }

        public static List<CachorroModel> Criarlista()
        {
            var lista = new List<CachorroModel>();
            

            lista.Add(new CachorroModel() { Raça = "Pug", Sexo = "F", Idade = 2});
            lista.Add(new CachorroModel() { Raça = "Poodle", Sexo = "F", Idade = 3});
            lista.Add(new CachorroModel() { Raça = "Labrador", Sexo = "M", Idade = 1});
            lista.Add(new CachorroModel() { Raça = "Pastor alemão", Sexo = "M", Idade = 4});
            lista.Add(new CachorroModel() { Raça = "Shih tzu", Sexo = "F", Idade = 2});

            return lista;
        }
    }
}
