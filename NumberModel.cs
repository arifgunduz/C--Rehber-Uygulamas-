using System;



namespace rehber_uygulamasi{

  public class NumberModel{

      public NumberModel(string name,string surname,string num){

          this.Name=name;
          this.Surname=surname;
          this.Num=num;



      }

      public string Name{get;set;}
      public string Surname{get;set;}
      public string Num{get;set;}
  }



}