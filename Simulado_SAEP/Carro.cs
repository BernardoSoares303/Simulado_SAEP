using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace Simulado_SAEP
{
    public class Carro
    {
        public string modelo_carro { get; set; }
        public int ano_carro { get; set; }
        public string avarias { get; set; }
        public double valor_carro { get; set; }
        public string cor { get; set; }
        public string placa { get; set; }
        public string chassi { get; set; }
        public string tipo_combustivel { get; set; }
        public int qaunt_portas { get; set; }
        public double max_velocidade { get; set; }
        public bool importado { get; set; }
        public int potencia { get; set; }
        public double km_rodados { get; set; }
    }
}
