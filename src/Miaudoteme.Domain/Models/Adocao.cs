using Miaudoteme.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miaudoteme.Domain.Models
{
    public class Adocao : Entidade
    {
        public string Codigo { get; private set; }
        public DateTime? DataAdocao { get; private set; }

        public Guid AnimalId { get; set; }
        public Animal Animal { get; private set; }

        public Guid AbrigoId { get; private set; }
        public Abrigo Abrigo { get; private set; }

        public Guid TutorId { get; private set; }
        public Tutor Tutor { get; private set; }

        public Guid ContribuicaoId { get; private set; }
        public Contribuicao Contribuicao { get; private set;}
        public Situacao Situacao { get; private set;}

        public Adocao(DateTime? dataAdocao, Guid animalId, Guid abrigoId, Guid tutorId, Guid contribuicaoId, Situacao situacao)
        {
            Codigo = Id.ToString().Replace("-","")[..10];
            DataAdocao = dataAdocao;
            AnimalId = animalId;
            AbrigoId = abrigoId;
            TutorId = tutorId;
            ContribuicaoId = contribuicaoId;
            Situacao = situacao;
        }
    }
}
