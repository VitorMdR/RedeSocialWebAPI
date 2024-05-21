using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace RedeSocialWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComentarioController
    {
        private PublicacaoController publicacao = new PublicacaoController();
        public List<Comentario> listaComentarios = new List<Comentario>
        {
            new Comentario(1, "Poeta!", "Guto", 1),
            new Comentario(2, "Sensacional!", "Jonas", 2),
            new Comentario(3, "Uau!", "André", 3),
            new Comentario(4, "Incrível!", "Anônimo", 4),
            new Comentario(5, "Chuchu beleza!", "Soneca", 5),
        };

        //comentario: Criar um novo comentário;

        [HttpPost]
        public List<Comentario> PostNewComment([FromBody] Comentario novoComentario)
        {
            listaComentarios.Add(novoComentario);

            return listaComentarios;
        }

        //comentario/{id}: Buscar um comentário pelo identificador;

        [HttpGet]
        [Route("{id}")]
        public Comentario GetCommentById(int id)
        {
            var comentarioBuscado = listaComentarios.Find(c => c.Id == id);

            return comentarioBuscado;
        }

        //comentario/{idPublicacao}: Buscar comentários de uma publicação especifica;

        // [HttpGet]
        // [Route("{idPublicacao}")]
        // public List<Comentario> GetCommentsByPostId(int idPublicacao)
        // {
        //     var publicacaoBuscada = publicacao.listaPublicacao.Find(p => p.Id == idPublicacao);

        //     var comentariosBuscados = publicacaoBuscada.listaComentarios;

        //     return comentariosBuscados;
        // }

        //comentario/{id}: Curtir um comentario; (Deve retornar o número de curtidas
        //atualizado)

        [HttpPut]
        [Route("{id}")]
        public int Put(int id)
        {

            var comentarioBuscado = listaComentarios.Find(p => p.Id == id);

            var numeroComentarios = comentarioBuscado.QtdCurtidas++;

            return numeroComentarios;
        }

        //comentario/{id}: Deletar um comentario pelo identificador;

        [HttpDelete]
        public List<Comentario> Delete([FromBody] Publicacao publicacaoRemovida)
        {

            var comentarioBuscado = listaComentarios.Find(p => p.Id == publicacaoRemovida.Id);

            listaComentarios.Remove(comentarioBuscado);


            return listaComentarios;
        }
    }
}
