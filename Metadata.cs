using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace FirstGuiClient
{
    public class Metadata
    {
        [Key]
        public Int64 ScanId { get; set; } //int, maybe long????

        //    public virtual ScanData ScanData { get; set; }
        //}

        //public class ScanData
        //{
        public string PatientIdnp { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public string TissueType { get; set; }
        public string TissueDescription { get; set; }
        public string ClinicalDiagnosis { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public string DoctorDegree { get; set; }
        public byte[] Image { get; set; }

        public Metadata()
        { }
    }

    public class MetadataContext : DbContext
    {
        public DbSet<Metadata> Scans { get; set; }

        public MetadataContext() : base()
        { }

    }

    //public class MetadataContext : DbContext
    //{
    //    public MetadataContext() : base()
    //    {

    //    }


    //}
}