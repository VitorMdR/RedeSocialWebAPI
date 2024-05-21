using System;
using System.Collections.Generic;

namespace RedeSocialWebAPI
{
    public class Publicacao
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string NomeUsuario { get; set; }
        public int QtdCurtidas { get; set; }

        public Publicacao()
        {

        }

        public Publicacao(int id, string titulo, string nomeUsuario, int QtdCurtidas)
        {
            Id = id;
            Titulo = titulo;
            DataPublicacao = DateTime.Now;
            NomeUsuario = nomeUsuario;
        }
        public void ReceberCurtida()
        {
            QtdCurtidas++;
        }
    }
}
