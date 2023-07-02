using HealthCare.SharedAssets;
using System;

namespace HealthCare.Documents.Api.Models
{
    public class Document : BaseEntity<Guid>
    {

        public Guid PatientId { get;  set; }
        public string Name { get;  set; }
        public string Path { get;  set; }
        public Document(Guid id,
          Guid patientId,
          string name,
          string path)
        {
            Id = id;
            PatientId = patientId;
            Path = path;
            Name = name;
        }

    }
}