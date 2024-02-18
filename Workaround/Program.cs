﻿using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;


SelamVer("Kubra");
SelamVer("Ali");
SelamVer();

int sonuc = Topla(6, 58);

string ogrenci1 = "Ali";
string ogrenci2 = "Veli";
string ogrenci3 = "Elif";

//Console.WriteLine(ogrenci1);
//Console.WriteLine(ogrenci2);
//Console.WriteLine(ogrenci3);

string[] ogrenciler = new string[3];
ogrenciler[0] = "Ali";
ogrenciler[1] = "Veli";
ogrenciler[2] = "Elif";
ogrenciler = new string[4];
ogrenciler[3] = "Cem";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

Person person1 = new Person();
person1.FirstName = "Kübra";
person1.LastName = "Kılıç";
person1.DateOfBirthYear = 1997;
person1.NationalIdentity = 1;

Person person2 = new Person();
person2.FirstName = "Esra";

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
yeniSehirler1.Add("Adana1");
foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine();


static void SelamVer(string isim = "noname")
{
    Console.WriteLine("Merhaba " + isim);
}

static int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam " + sonuc);
    return sonuc;
}


