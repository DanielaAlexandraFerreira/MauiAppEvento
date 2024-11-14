using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppEvento.Models
{
    public class Evento
    {
        public string Nome {  get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino {  get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local {  get; set; }
        public double CustoParticipante { get; set; }
        public TimeSpan TotalDias
        {
            get => DataTermino - DataInicio;
        }
        public double CustoTotal
        {
            get => (NumeroParticipantes * CustoParticipante);
        }
    }
}
