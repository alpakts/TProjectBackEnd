using Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string FormAdded = "form eklendi";
        public static string UserAdded = "kullanıcı eklendi";
        public static string userInvalid = "kullanıcı  bulunamadı";
        public static string ProductListed = "ürünler lsitelendi";
        public static string MaintanceTime = "Sunucu bakımda";
        public static string  userDeleted = "kullanıcı silindi";
        internal static string UserGet="Maillere göre kullanıcılar getirildi";
        internal static string claimDeleted;
        internal static string claimAdded;
        internal static string claimBrought;

        public static string InvalidUnitPrice { get; internal set; }
        
        public static string CategoryLimitExceed { get; internal set; }
        public static string AuthorizationDenied { get; internal set; }
        public static string UserNotFound { get; internal set; }
        public static string UserRegistered { get; internal set; }
        public static string PasswordError { get; internal set; }
        public static string SuccessfulLogin { get; internal set; }
        public static string UserAlreadyExists { get; internal set; }
        public static string AccessTokenCreated { get; internal set; }
        public static string UserUpdated { get; internal set; }
        public static string claimUpdated { get; internal set; }
    }
}
