using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        //Atributos

        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Deleted { get; set; }

        //Metodos
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Deleted = false;
        }
        public override string ToString()
        {
            string retorno = "";
            retorno +="Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de lançamento: " + this.Ano + Environment.NewLine; 
            retorno += "Excluido = " + this.Deleted;
            return retorno;

        }
        public string retornaTitulo()
        { 
            return this.Titulo; 
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void Delete()
        {
            this.Deleted = true;
        }
    }

}
