using System;

namespace RedeSocialWebAPI
{
    public class Comentario
    {   
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataComentario { get; set; }
        public string NomeUsuarioComentario { get; set; }
        public int QtdCurtidas { get; set; }
        public int IdPublicacao { get; set; }

        public Comentario()
        {
            
        }

        public Comentario(int id, string descricao, string nomeUsuarioComentario, int idPublicacao)
        {
            Id = id;
            Descricao = descricao;
            DataComentario = DateTime.Now;
            NomeUsuarioComentario = nomeUsuarioComentario;
            IdPublicacao = idPublicacao;
        }
        
        public void ReceberCurtida()
        {
            QtdCurtidas++;
        }
    }
}
