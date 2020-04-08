// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20184.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TenantDto
    {
        /// <summary>
        /// Initializes a new instance of the TenantDto class.
        /// </summary>
        public TenantDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TenantDto class.
        /// </summary>
        /// <param name="name">Name of the tenant.</param>
        /// <param name="adminEmailAddress">Default tenant's admin user account
        /// email address.</param>
        /// <param name="adminName">Default tenant's admin user account
        /// name.</param>
        /// <param name="adminSurname">Default tenant's admin user account
        /// surname.</param>
        /// <param name="adminPassword">Default tenant's admin user account
        /// password. Only valid for create/update operations.</param>
        /// <param name="lastLoginTime">The last time a user logged in this
        /// tenant</param>
        /// <param name="isActive">Specifies if the tenant is active or
        /// not.</param>
        /// <param name="license">Licensing info.</param>
        public TenantDto(string name = default(string), string adminEmailAddress = default(string), string adminName = default(string), string adminSurname = default(string), string adminPassword = default(string), System.DateTime? lastLoginTime = default(System.DateTime?), bool? isActive = default(bool?), TenantLicenseDto license = default(TenantLicenseDto), int? id = default(int?))
        {
            Name = name;
            AdminEmailAddress = adminEmailAddress;
            AdminName = adminName;
            AdminSurname = adminSurname;
            AdminPassword = adminPassword;
            LastLoginTime = lastLoginTime;
            IsActive = isActive;
            License = license;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the tenant.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets default tenant's admin user account email address.
        /// </summary>
        [JsonProperty(PropertyName = "AdminEmailAddress")]
        public string AdminEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets default tenant's admin user account name.
        /// </summary>
        [JsonProperty(PropertyName = "AdminName")]
        public string AdminName { get; set; }

        /// <summary>
        /// Gets or sets default tenant's admin user account surname.
        /// </summary>
        [JsonProperty(PropertyName = "AdminSurname")]
        public string AdminSurname { get; set; }

        /// <summary>
        /// Gets or sets default tenant's admin user account password. Only
        /// valid for create/update operations.
        /// </summary>
        [JsonProperty(PropertyName = "AdminPassword")]
        public string AdminPassword { get; set; }

        /// <summary>
        /// Gets or sets the last time a user logged in this tenant
        /// </summary>
        [JsonProperty(PropertyName = "LastLoginTime")]
        public System.DateTime? LastLoginTime { get; set; }

        /// <summary>
        /// Gets or sets specifies if the tenant is active or not.
        /// </summary>
        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Gets or sets licensing info.
        /// </summary>
        [JsonProperty(PropertyName = "License")]
        public TenantLicenseDto License { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name != null)
            {
                if (Name.Length > 64)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 64);
                }
                if (Name.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 0);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(Name, "^[\\p{L}][\\p{L}0-9-_]+$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "Name", "^[\\p{L}][\\p{L}0-9-_]+$");
                }
            }
            if (AdminEmailAddress != null)
            {
                if (AdminEmailAddress.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "AdminEmailAddress", 256);
                }
                if (AdminEmailAddress.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "AdminEmailAddress", 0);
                }
            }
            if (AdminName != null)
            {
                if (AdminName.Length > 32)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "AdminName", 32);
                }
                if (AdminName.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "AdminName", 0);
                }
            }
            if (AdminSurname != null)
            {
                if (AdminSurname.Length > 32)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "AdminSurname", 32);
                }
                if (AdminSurname.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "AdminSurname", 0);
                }
            }
            if (AdminPassword != null)
            {
                if (AdminPassword.Length > 32)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "AdminPassword", 32);
                }
                if (AdminPassword.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "AdminPassword", 0);
                }
            }
        }
    }
}
