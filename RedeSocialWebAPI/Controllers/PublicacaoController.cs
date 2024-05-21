using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace RedeSocialWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PublicacaoController : ControllerBase
    {
        //Os dados devem ser manipulados em memória como os ultimos
        //exercícios da aula.
        public List<Publicacao> listaPublicacao = new List<Publicacao>
        {
            new Publicacao(1, "Batatinha quando nasce", "Guto", 2),
            new Publicacao(2, "Jacaré não tem pescoço", "Jonas", 5),
            new Publicacao(3, "Se você não gosta de bolo", "André", 8),
            new Publicacao(4, "Por que roubou minha bicicleta", "Anônimo", 4),
            new Publicacao(5, "Hãme?", "Soneca", 2),
        };
        //publicacao: Criar uma nova publicação;
        [HttpPost]
        public List<Publicacao> Post([FromBody] Publicacao novaPublicacao)
        {
            listaPublicacao.Add(novaPublicacao);

            return listaPublicacao;
        }
        //publicacao/{id}: Buscar uma publicação pelo identificador;
        [HttpGet]
        [Route("{id}")]
        public Publicacao Get(int id)
        {
            var publicacaoBuscada = listaPublicacao.Find(p => p.Id == id);

            return publicacaoBuscada;
        }
        //publicacao: Editar uma publicacao; (A data da publicação deve ser editada)
        [HttpPut]
        public List<Publicacao> Put([FromBody] Publicacao publicacaoEditada)
        {

            var publicacaoBuscada = listaPublicacao.Find(p => p.Id == publicacaoEditada.Id);

            publicacaoBuscada.Titulo = publicacaoEditada.Titulo;

            publicacaoBuscada.DataPublicacao = DateTime.Now;

            return listaPublicacao;
        }
        //publicacao/{id}: Curtir uma publicação;
        //(Deve retornar o número de curtidas atualizado)
        [HttpPut]
        [Route("{id}")]
        public int Put(int id)
        {

            var publicacaoBuscada = listaPublicacao.Find(p => p.Id == id);

            var numeroPublicacoes = publicacaoBuscada.QtdCurtidas++;

            return numeroPublicacoes;
        }
        //comentario/{id}: Deletar um comentario pelo identificador;
        [HttpDelete]
        public List<Publicacao> Delete([FromBody] Publicacao publicacaoRemovida)
        {

            var publicacaoBuscada = listaPublicacao.Find(p => p.Id == publicacaoRemovida.Id);

            listaPublicacao.Remove(publicacaoBuscada);


            return listaPublicacao;
        }
    }
}
