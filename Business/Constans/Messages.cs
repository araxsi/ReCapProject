using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string DescriptionInvalid = "Açıklama geçersiz";
        public static string DailyPriceInvalid = "Günlük kiralama ücreti girmediniz";
        internal static string MaintemanceTime = "Arabalar Listelemeye Kapalı";
        internal static string CarListed = "Arabalar Listelendi";
        public static string CarDelete = "Araba sistemden silindi";
        public static string CarGetById = "Arabalar ID numaralarına göre listelenmistir.";
        public static string CarUpdate = "Seçili araba güncellenmiştir";
        public static string UserAdd = "Kullanıcı eklendi";
        public static string RentalInvalid = "Araç suan başka bir müsterinin kullanımındadır.";
        public static string BrandListed = "Modeller Listelendi";
        public static string ColorListed = "Renkler Listelendi";

        public static string UserRegistered = "Kullanıcı Kaydı yapılmıştır.";
        public static string UserNotFound = "Kullanıcı Bulunamamıştır.";
        public static string PasswordError = "Parola Hatalıdır.";
        public static string SuccessfulLogin = "Giriş Yapılmıştır.";
        public static string UserAlreadyExists = "Kullanıcı daha önce giriş yapmıştır.";
        public static string AccessTokenCreated = "Anahtar Oluşturulmuştur.";
        public static string AuthorizationDenied = "Anahtar Hatalıdır";
        internal static string CarImageLimitExceeded;
    }
}