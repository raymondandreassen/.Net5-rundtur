using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Demo1.Shared.Model
{
    public class User
    {
        /* 
         * Heftig bruk av Data Annotation, ganske overdrevet..
         * Har aldri møtt på et behov som ikke er løsbart med DataAnnotation. 
         * Det er også mulig å lage egne data validators. 
         * 
         * Kommentarene blir eksportert til dokumentasjonen. 
         */


        internal User()
        {
            UserID = Guid.NewGuid();
        }

        /// <summary>
        /// Unique User identifier
        /// </summary>
        [Key]
        [Column(Order = 1)]
        public Guid UserID { get; }

        [Key]
        [Column(Order = 2)]
        public int UserNumber { get; set; }

        /// <summary>
        /// The users username, between 8 and 30 chars. 
        /// TODO: Should be get; init;
        /// </summary>
        [Required, MaxLength(30, ErrorMessage = "Username must be less than 30 characters"), MinLength(8, ErrorMessage = "Username must be at least 8 char")]
        public string UserName { get; set; }

        [Required]
        public string DisplayName { get; set; }

        /// <summary>
        /// Maxlength 250 char.
        /// Make the system validate the email address as valid. 
        /// </summary>
        [EmailAddress, MaxLength(250, ErrorMessage = "Email adress must be valid and less than 250 char")]
        public string EmailAddress { get; set; }


        [Encrypted, MaxLength(1000, ErrorMessage = "Secret must be less than 1000 characters"), MinLength(5, ErrorMessage = "Secret must be at least 10 char")]
        public string UserSecretInfo { get; set; }

        [Encrypted] 
        [MaxLength(100)]
        public string SomeInfo { get; set; }

#region System properties
        [Column("SystemCreated", TypeName = "smalldatetime"), DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Created { get; init; }

        [Column("SystemUpdated", TypeName = "smalldatetime")]
        public DateTime Modified { get; set; }
#endregion

        public List<BrukerInfo> Blogposts { get; }

        /// <summary>
        /// Verdier trenger ikke å bli lagret i databasen, det settes med "NotMapped"
        /// </summary>
        [NotMapped]
        public int SomeTempValue { get; set; }
    }


    public class Employee : User 
    {
        internal Employee() : base()
        { }

        public int EmployeeID { get; set; }

        public Department Department { get; set; }
    }

    public class Student : User
    {
        internal Student() : base()
        { }

        public int StudentNumber { get; set; }   
    }
}
