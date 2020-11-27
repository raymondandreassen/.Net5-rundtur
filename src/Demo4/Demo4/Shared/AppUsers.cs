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

        public AppUser()
        {
            UserID = Guid.NewGuid();
            Created = DateTime.Now;
        }
        public AppUser(AppUser appuser)
        {
            this.UserID = appuser.UserID;
            this.UserNumber = appuser.UserNumber;
            this.EmailAddress = appuser.EmailAddress;
            this.UserSecretInfo = appuser.UserSecretInfo;
            this.EmployeeOrStudent = appuser.EmployeeOrStudent;
        }

        /// <summary>
        /// Unique User identifier
        /// </summary>
        [Key]
        [Column(Order = 1)]
        public Guid UserID { get; set;  }

        public int UserNumber { get; set; }

        [Required, MaxLength(30, ErrorMessage = "Username must be less than 30 characters"), MinLength(6, ErrorMessage = "Username must be at least 6 char")]
        public string UserName { get; set; }

        /// <summary>
        /// Maxlength 250 char.
        /// Make the system validate the email address as valid. 
        /// </summary>
        [Required, EmailAddress, MaxLength(250, ErrorMessage = "Email adress must be valid and less than 250 char")]
        public string EmailAddress { get; set; }

        [Encrypted, MaxLength(1000, ErrorMessage = "Secret must be less than 1000 characters"), MinLength(5, ErrorMessage = "Secret must be at least 10 char")]
        public string UserSecretInfo { get; set; }

        #region System properties
        [Column("SystemCreated", TypeName = "smalldatetime")]
        public DateTime Created { get; set; }

        [Column("SystemUpdated", TypeName = "smalldatetime")]
        public DateTime Modified { get; set; }
        #endregion

        // Skal ikke ned i databasen, kunne vært en funksjon, struct, etc. 
        [NotMapped]
        public bool EmployeeOrStudent { get; set; } = false;

        [Range(10000, 99999, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int EmployeeID { get; set; }

        [Range(100000, 999999, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int StudentNumber { get; set; }
    }
}
