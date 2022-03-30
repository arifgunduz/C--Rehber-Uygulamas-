using System;



namespace rehber_uygulamasi{
  
     
     public static class Islemlerim{

        public static void IslemlerYazdir(){
       
       Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Çıkmak İçin 1-5 Dışında Her Hangi Bir Şey Girmeniz Yeterlidir.");
    } 
      
      public static bool KontrolNumara(int num){

          if(num >=1 && num<=5){
              return true;
          }else {
              return false;
          }

      }

      public static void AddNewNumber(){
          Console.WriteLine("Lütfen isminizi giriniz");
          string name=Console.ReadLine();
          Console.WriteLine("Lütfen soy isminizi giriniz");
          string surname=Console.ReadLine();
          Console.WriteLine("Lütfen telefon Numaranızı Giriniz");
          string num=Console.ReadLine();
          Rehberim.RehberList.Add(new NumberModel(name,surname,num));
      }

      public static void DeleteNumber(){

          Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
          int check=0;
          string fullname=Console.ReadLine();
          
          foreach(var item in Rehberim.RehberList){
              if(item.Name.ToLower() == fullname.ToLower() || item.Surname.ToLower() == fullname.ToLower()){

                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", fullname);
                    char control =char.Parse(Console.ReadLine());

                    if(control == 'y'){
                        int deleteIndex=Rehberim.RehberList.IndexOf(item);
                        Rehberim.RehberList.RemoveAt(deleteIndex);
                        check++;
                         Console.WriteLine("Silme Onayı Başarılı, Çıkılıyor...");
                         break;
                    }else{
                        check++;
                         Console.WriteLine("Silme Onayı Başarısız, Çıkılıyor...");
                        break;
                    }
              }
          }
          if(check ==0){
              Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                int selecion=int.Parse(Console.ReadLine());
                if(selecion ==2){
                    while(selecion==2){
                        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                                 fullname = Console.ReadLine();
                        foreach(var item2 in Rehberim.RehberList){
                            if(item2.Name.ToLower()==fullname.ToLower() || item2.Surname.ToLower() == fullname.ToLower()){
                                
                                Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", fullname);
                                 
                                 char control=char.Parse(Console.ReadLine());
                                 if(control=='y'){
                                     int deleteIndex=Rehberim.RehberList.IndexOf(item2);
                                     Rehberim.RehberList.RemoveAt(deleteIndex);
                                     check++;
                                     selecion=3;
                                     Console.WriteLine("Silme Onayı Başarılı, Çıkılıyor...");
                                    break;

                                 }
                                 else {
                                     check++;
                                     selecion=3;
                                     Console.WriteLine("Silme Onayı Başarısız, Çıkılıyor...");
                                    break;
                                 }
                            }
                        }
                        if(check ==0){
                               Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                                Console.WriteLine("* Yeniden denemek için      : (2)");
                                selecion =int.Parse(Console.ReadLine());
                        }
                    }
                }
          }
      }

      public static  void UpdateNumber(){

          Console.WriteLine(" Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
          string fullname=Console.ReadLine();
          int count=Rehberim.RehberList.Count;
          int updateControl=0;

           for(var i=0; i<count;i++){
               if(Rehberim.RehberList[i].Name.ToLower() == fullname.ToLower()  || Rehberim.RehberList[i].Surname.ToLower() == fullname.ToLower()){
                    Console.WriteLine("Kişi Bulundu ve Telefon Numarası: {0}",Rehberim.RehberList[i].Num);
                    Console.WriteLine("Lütfen güncellemek istediğiniz telefon numarasını giriniz...");

                    string newNumber=Console.ReadLine();
                    Rehberim.RehberList[i].Num=newNumber;
                    Console.WriteLine("Telefon Numarası Güncellemesi Başarılı, Çıkılıyor...");
                    updateControl++;
                    break;
               }
           }
           if(updateControl ==0){
                Console.WriteLine("Telefon Numarası Güncellemesi Başarısız, Çıkılıyor...");
           }
           
          
          
                }
         
         public static void RehberListed(){

             Console.WriteLine("Telefon Rehberi");
              Console.WriteLine("**********************************************");

             for(int i=0;i<Rehberim.RehberList.Count;i++){

                 Console.WriteLine("isim : {0}",Rehberim.RehberList[i].Name);
                 Console.WriteLine("soyisim : {0}",Rehberim.RehberList[i].Surname);
                 Console.WriteLine("Telefon Numarası : {0}",Rehberim.RehberList[i].Num);
                 Console.WriteLine("-");
             }
         }

         public static void RehberArama(){

             Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
              Console.WriteLine(" **********************************************");

                 Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)");
                  Console.WriteLine("  Telefon numarasına göre arama yapmak için: (2)");
               
                  int selecion=int.Parse(Console.ReadLine());
                  if(selecion==1){
                                 Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin adını ya da soyadını giriniz:");
                                 string fullname=Console.ReadLine();
                      foreach(var item3 in Rehberim.RehberList){

                          if(item3.Name.ToLower()== fullname.ToLower() || item3.Surname.ToLower() == fullname.ToLower() ){
                              Console.WriteLine(" Arama Sonuçlarınız:");
                              Console.WriteLine("  **********************************************");

                              Console.WriteLine("isim : {0}",item3.Name);
                              Console.WriteLine("soyisim : {0}",item3.Surname);
                              Console.WriteLine("numarası : {0}",item3.Num);
                                Console.WriteLine("-");
                           
                          }
                        } 
                        } else  if(selecion ==2){
                                Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin telefon numarasını giriniz:");
                                string fullNo=Console.ReadLine();

                                foreach(var item4 in Rehberim.RehberList){
                                     if(item4.Num == fullNo ){
                                     Console.WriteLine("isim: {0}", item4.Name);
                                     Console.WriteLine("Soyisim: {0}", item4.Surname);
                                     Console.WriteLine("Telefon Numarası: {0}", item4.Num);
                                     Console.WriteLine("-");
                                     }
                                }
                                  Console.WriteLine("Arama İşlemi Bitti, Çıkılıyor...");

                          }else {
                                     Console.WriteLine("Hatalı Seçim, Çıkılıyor...");
                          }
                      
                  

         }



     
  
     }
   









}