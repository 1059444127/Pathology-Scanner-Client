namespace FirstGuiClient
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'FirstGuiClient.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("name=Model1")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Metadata> Scans { get; set; }
    }

    public class Metadata
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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
        
    }
}