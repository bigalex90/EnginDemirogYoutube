// See https://aka.ms/new-console-template for more information
using OOP3;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");



TasitKrediManager TasitKrediManager = new TasitKrediManager();
KonutKrediManager KonutKrediManager = new KonutKrediManager();
IhtiyacKrediManager IhtiyacKrediManager = new IhtiyacKrediManager();


//TasitKrediManager.Hesapla();
//KonutKrediManager.Hesapla();
//IhtiyacKrediManager.Hesapla();
    
BasvuruManager BasvuruManager = new BasvuruManager();
ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService=new FileLoggerService();
List<ILoggerService> loggerServices = new List<ILoggerService>() {new DatabaseLoggerService(),new FileLoggerService(),new SmsLogger() };

//BasvuruManager.BasvuruYap(TasitKrediManager);
//BasvuruManager.BasvuruYap(KonutKrediManager);
//BasvuruManager.BasvuruYap(IhtiyacKrediManager);
List<IKrediManager> krediler = new List<IKrediManager>() { TasitKrediManager,KonutKrediManager,IhtiyacKrediManager};
//BasvuruManager.KrediOnBilgilendirme(krediler);


BasvuruManager.BasvuruYap(new EsnafKrediManager(), loggerServices);