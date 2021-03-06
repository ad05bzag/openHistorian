// ReSharper disable CheckNamespace
#pragma warning disable 1591

using System;
using System.ComponentModel.DataAnnotations;
using GSF.ComponentModel.DataAnnotations;
using GSF.Data.Model;
using GSF.Web.Model;

namespace openHistorian.Model
{
    public class Vendor
    {
        [PrimaryKey(true)]
        public int ID
        {
            get;
            set;
        }

        [Required]
        [StringLength(200)]
        [RegularExpression("^[A-Z0-9\\-!_\\.@#\\$]+$", ErrorMessage = "Only upper case letters, numbers, '!', '-', '@', '#', '_' , '.'and '$' are allowed.")]
        [Searchable]
        public string Acronym
        {
            get;
            set;
        }

        [Required]
        [StringLength(200)]
        [Searchable]
        public string Name
        {
            get;
            set;
        }

        [Label("Phone Number")]
        [StringLength(200)]
        public string PhoneNumber
        {
            get;
            set;
        }

        [Label("E-Mail")]
        [StringLength(200)]
        public string ContactEmail
        {
            get;
            set;
        }

        [Label("Web Page")]
        [RegularExpression(DataContext.UrlValidation, ErrorMessage = "Invalid URL.")]
        public string URL
        {
            get;
            set;
        }

        public DateTime CreatedOn
        {
            get;
            set;
        }

        [Required]
        [StringLength(200)]
        public string CreatedBy
        {
            get;
            set;
        }

        public DateTime UpdatedOn
        {
            get;
            set;
        }

        [Required]
        [StringLength(200)]
        public string UpdatedBy
        {
            get;
            set;
        }
    }
}