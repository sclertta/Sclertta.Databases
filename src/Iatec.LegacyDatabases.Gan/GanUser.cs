using System;
using System.Collections.Generic;

namespace Iatec.LegacyDatabases.Gan
{
    public partial class GanUser
    {
        public Guid UserId { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public DateTime? LastLockOutDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? LastPasswordChangedDate { get; set; }
        public DateTime? OneTimePasswordGenDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? OneTimePasswordGenCount { get; set; }
        public int? PasswordFailedCount { get; set; }
        public bool? IsLockedOut { get; set; }
        public string LastTwoFactAuthCode { get; set; }
        public int? MobileMsgSendCount { get; set; }
        public DateTime? LastMobileMsgSendDate { get; set; }
        public DateTime? Birthdate { get; set; }
        public string LanguageCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] Photo { get; set; }
        public string AlternateEmail { get; set; }
        public bool? IsTwoFactorAuthEnabled { get; set; }
        public byte[] Password { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] PasswordAnswer { get; set; }
        public string PasswordQuestion { get; set; }
        public string OneTimeCode { get; set; }
        public string UserName { get; set; }
        public string TwoFactorAuthSecret { get; set; }
        public int? TwoFactorAuthTypeEnum { get; set; }
        public int? GenderEnum { get; set; }
        public string Email { get; set; }
    }
}
