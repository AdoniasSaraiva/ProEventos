using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {


            public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){
                    EventoId = 1,
                    Tema = "Angular and dotnet",
                    Local = "Belo Horizon",
                    Lote = "1º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImageURL = "C://https:Adonias/adonias.json"
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "Angular and C#",
                    Local = "São Paulo",
                    Lote = "3º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImageURL = "C://https:Adonias/adoniasNeves.json"
                }
    };

        public EventoController()
        {
        
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(x => x.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com Id  {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de delete com Id {id}";
        }
    }
}
