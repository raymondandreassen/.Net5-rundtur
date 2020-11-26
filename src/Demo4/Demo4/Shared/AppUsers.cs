using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4.Shared
{
    public class AppUser
    {
        /* Advarsel: Overdreven bruk av Data Annotation */

        internal AppUser()
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

        [Required, MaxLength(30, ErrorMessage = "Username must be less than 30 characters"), MinLength(8, ErrorMessage = "Username must be at least 8 char")]
        public string UserName { get; set; }

        /// <summary>
        /// Maxlength 250 char.
        /// Make the system validate the email address as valid. 
        /// </summary>
        [EmailAddress, MaxLength(250, ErrorMessage = "Email adress must be valid and less than 250 char")]
        public string EmailAddress { get; set; }

        [Encrypted, MaxLength(1000, ErrorMessage = "Secret must be less than 1000 characters"), MinLength(5, ErrorMessage = "Secret must be at least 10 char")]
        public string UserSecretInfo { get; set; }


        #region System properties
        [Column("SystemCreated", TypeName = "smalldatetime"), DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Created { get; init; }

        [Column("SystemUpdated", TypeName = "smalldatetime")]
        public DateTime Modified { get; set; }
        #endregion

        // Skal ikke ned i databasen, kunne vært en funksjon, struct, etc. 
        [NotMapped]
        public int SomeTempValue { get; set; }
    }

    public class Employee : AppUser
    {
        internal Employee() : base()
        { }
        public int EmployeeID { get; set; }

    }

    public class Student : AppUser
    {
        internal Student() : base()
        { }

        public int StudentNumber { get; set; }
    }
}
