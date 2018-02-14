using System;
using System.Collections.Generic;

namespace Sclertta.Databases.Persons
{
    public partial class NaturalPersonSimilar
    {
        public Guid NaturalPersonSimilarId { get; set; }
        public Guid MainNaturalPersonId { get; set; }
        public Guid SimilarNaturalPersonId { get; set; }

        public NaturalPerson MainNaturalPerson { get; set; }
        public NaturalPerson SimilarNaturalPerson { get; set; }
    }
}
