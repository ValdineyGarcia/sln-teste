using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    public class CentroDeCusto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public decimal VerbaLiberada { get; set; }
        public int AnoVerbaLiberada { get; set; }

        public CentroDeCusto
            (int Id,
            string descricao, 
            DateTime dataCriacao, 
            decimal verbaLiberada, 
            int anoVerbaLiberada) 
        {
            Id = Id;
            Descricao = descricao;  
            DataCriacao = dataCriacao;
            VerbaLiberada= verbaLiberada;  
            AnoVerbaLiberada= anoVerbaLiberada;
        }


    }
}
