using System;

namespace rehber_uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {

              
             Rehberim.RehberList.Add(new NumberModel("Birkan", "Çakmak", "123"));
             Rehberim.RehberList.Add(new NumberModel("Sıla", "Akan", "456"));
             Rehberim.RehberList.Add(new NumberModel("Ahmet", "Sayar", "789"));
             Rehberim.RehberList.Add(new NumberModel("Büşra", "Kızıl", "123"));
             Rehberim.RehberList.Add(new NumberModel("Aslı", "Çakmak", "852"));
           
           Islemlerim.IslemlerYazdir();
           int select=int.Parse(Console.ReadLine());

           while(Islemlerim.KontrolNumara(select)){
               if(select == 1 ){
                   Islemlerim.AddNewNumber();
               }else if(select ==2 ){
                   Islemlerim.DeleteNumber();
            }else if(select ==3){
                Islemlerim.AddNewNumber();
            }else if(select==4){
                Islemlerim.RehberListed();
            }else if(select ==5){
                Islemlerim.RehberArama();
            }else {
                  Console.WriteLine("1-5 Aralığı Dışında Bir Sayı Girildi, Çıkılıyor...");
                    break;
            }
           Islemlerim.IslemlerYazdir();
           select=int.Parse(Console.ReadLine());

            
           }
             Console.WriteLine("Rehberin Son Hali: ");
             Islemlerim.RehberListed();
             Console.WriteLine("Program Sona Erdi, Çıkmak İçin Herhangi Bir Tuşa Basınız...");
            Console.ReadKey();
          


        }
    }
}
