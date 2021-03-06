using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime ="Sistem bakımda";
        public static string ProductListed="Ürünler listelendi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün bulunabilir.";
        public static string ProductNameAlreadyExits="Bu isimde zaten bir ürün var!";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied= "Yetkiniz yok!";
        public static string UserRegistered;
        public static string UserAlreadyExists;
        public static string PasswordError;
        public static string SuccessfulLogin;
        public static string AccessTokenCreated;
        public static string UserNotFound;
        public static string ProductNameAlreadyExists;
        public static string ProductsListed;
    }
}
