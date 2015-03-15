using System.IO;
using System;

class Program
{
    static void Main()
    {
    	int ogrsayi;
        Console.WriteLine("Öğrenci Sayısını Girin");
        ogrsayi = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        string[] adlar = new string[300];
        int[] numara = new int[30];
        int[] fizik = new int[300];
        int[] kimya = new int[300];
        int[] bio = new int[300];
        Menu(ogrsayi,numara,fizik,kimya,bio,adlar);

    }

        public static void Menu(int ogrsayi,int [] numara,int [] fizik,int [] kimya,int [] bio,string [] adlar)
        {  
        	//Console.Clear();
        	int secim;
            Console.WriteLine("1 - Öğrenci Bilgileri Giriş");
        	Console.WriteLine("2 - Öğrencileri Giriş Sırasına Göre Listele");
        	Console.WriteLine("3 - Derslerin Sınav Ortalamaları");
        	Console.WriteLine("4 - 60 dan küçük olanları görüntüle");
        	Console.WriteLine("5 - Ortalamanın Üstünde Alan Öğrencileri Görüntüle");
        	Console.WriteLine("6 - Kaç kişi 60 ' dan düşük aldı ?");
        	Console.WriteLine("7 - En yüksek sınav sonucu (derse göre)");
        	Console.WriteLine("8 - En düşük sınav sonucu (derse göre)");
        	Console.WriteLine("9 - Ders Notlarına göre Sırala");
        	Console.WriteLine("10 - Öğrenci No suna Göre Sırala");
        	Console.WriteLine("0 - Çıkış");
            Console.WriteLine("Seçiminiz : ");
        secim = Convert.ToInt32(Console.ReadLine());
        switch(secim)
        {
          case 1:
          OgrEkle(ogrsayi,numara,fizik,kimya,bio,adlar);
          break;
          case 2:
          SıraList(ogrsayi,numara,fizik,kimya,bio,adlar);
          break;
          case 3:
          SınavlarOrt(ogrsayi,numara,fizik,kimya,bio,adlar);
          break;
          case 4:
          Kalanlar(ogrsayi,numara,fizik,kimya,bio,adlar);
          break;
          case 5:
          OrtalamaUstu(ogrsayi,numara,fizik,kimya,bio,adlar);
          break;
          case 6:
          AltmısAltıSayac(ogrsayi,numara,fizik,kimya,bio,adlar);
          break;
          case 7:
          EnYuksek(ogrsayi,numara,fizik,kimya,bio,adlar);
          break;
          case 8:
          EnDusuk(ogrsayi,numara,fizik,kimya,bio,adlar);
          break;
          case 9:
          OrtalamaSırala(ogrsayi,numara,fizik,kimya,bio,adlar);
          break;
          case 10:
          NumaraSırala(ogrsayi,numara,fizik,kimya,bio,adlar);
          break;
          case 0:
   		  Console.ReadLine();
          break;

        }
    }

  

   public static void OgrEkle(int ogrsayi,int [] numara,int [] fizik,int [] kimya,int [] bio,string [] adlar)
   {
   	for(int i=1;i<=ogrsayi;i++)
   	{
   		Console.WriteLine("{0}. Öğrencinin Numarası :",i);
   		numara[i] = Convert.ToInt32(Console.ReadLine());
   		Console.WriteLine("{0}. Öğrencinin Adı :",i);
   		adlar[i] = Console.ReadLine();
   		Console.WriteLine("{0}. Öğrencinin Fizik Notu :",i);
   		fizik[i] = Convert.ToInt32(Console.ReadLine());
   		Console.WriteLine("{0}. Öğrencinin Kimya Notu :",i);
   		kimya[i] = Convert.ToInt32(Console.ReadLine());
   		Console.WriteLine("{0}. Öğrencinin Biyoloji Notu :",i);
   		bio[i] = Convert.ToInt32(Console.ReadLine());

     }
     Console.WriteLine("Kayıt Tamamlandı");
     Console.Clear();
     Menu(ogrsayi,numara,fizik,kimya,bio,adlar);
   }
   
   public static void SıraList(int ogrsayi,int [] numara,int [] fizik,int [] kimya,int [] bio,string [] adlar)
   {
   	for(int i=1;i<=ogrsayi;i++)
   	{
   		Console.WriteLine("");
   		Console.WriteLine("{0} sıradaki öğrencinin numarası : {1}",i,numara[i]);
   		Console.WriteLine("{0} sıradaki öğrencinin adı : {1}",i,adlar[i]);
   		Console.WriteLine("{0} sıradaki öğrencinin fizik notu : {1}",i,fizik[i]);
   		Console.WriteLine("{0} sıradaki öğrencinin kimya notu : {1}",i,kimya[i]);
   		Console.WriteLine("{0} sıradaki öğrencinin numarası : {1}",i,bio[i]);
   		Console.WriteLine("");
   		Console.ReadLine();
   	}
   	Menu(ogrsayi,numara,fizik,kimya,bio,adlar);
   }
   public static float SınavlarOrt(int ogrsayi,int [] numara,int [] fizik,int [] kimya,int [] bio,string [] adlar)
   {
   	Console.Clear();
   	int secim1;
   	int temp = 0;
   	int fizikort;
    int kimyaort = 0;
    int bioort = 0;
   	Console.WriteLine("1 - Fizik Dersi Ortalaması");
   	Console.WriteLine("2 - Kimya Dersi Ortalaması");
   	Console.WriteLine("3 - Biyoloji Dersi Ortalaması");
   	Console.WriteLine("Seçiminiz :");
   	secim1 = Convert.ToInt32(Console.ReadLine());
   	switch(secim1)
   	{
   		case 1:
   		for(int i=1;i<=ogrsayi;i++)
   		{
   			temp+= fizik[i];
   		}
   		Console.WriteLine("Sınıfın Fizik Ortalaması: " + ((float)temp / ogrsayi));
   		break;
   		case 2:
   		for(int i=1;i<=ogrsayi;i++)
   		{
   			temp+= kimya[i];
   		}
   		Console.WriteLine("Sınıfın Kimya Ortalaması: " + ((float)temp / ogrsayi));
   		break;
   		case 3:
   		for(int i=1;i<=ogrsayi;i++)
   		{
   			temp+= bio[i];
   		}
   		
   		Console.WriteLine("Sınıfın Biyoloji Ortalaması: " + ((float)temp / ogrsayi));
   		break;
   	}

   	//Console.ReadLine();
   	Menu(ogrsayi,numara,fizik,kimya,bio,adlar);
   	return secim1;
   }
   public static void Kalanlar(int ogrsayi,int [] numara,int [] fizik,int [] kimya,int [] bio,string [] adlar)
   {
   	int secim2; 
    Console.WriteLine("1 - Fizik Dersi Ortalaması");
   	Console.WriteLine("2 - Kimya Dersi Ortalaması");
   	Console.WriteLine("3 - Biyoloji Dersi Ortalaması");
   	secim2 = Convert.ToInt32(Console.ReadLine());
   	switch(secim2)
   	{
   		case 1:
   		for(int i=1;i<=ogrsayi;i++)
   		{
   			if(fizik[i]<60)
   			{
   				Console.WriteLine("Ögrenci No : {0}",numara[i]);
   				Console.WriteLine("Öğrenci Adı : {0}",adlar[i]);
   				Console.WriteLine("");
   				Console.WriteLine("");

   			}
   		}
   		Menu(ogrsayi,numara,fizik,kimya,bio,adlar);
   		break;
   		case 2:
   		for(int i=1;i<=ogrsayi;i++)
   		{
   			if(kimya[i]<60)
   			{
   				Console.WriteLine("Ögrenci No : {0}",numara[i]);
   				Console.WriteLine("Öğrenci Adı : {0}",adlar[i]);
   				Console.WriteLine("");
   				Console.WriteLine("");

   			}
   		}
   		Menu(ogrsayi,numara,fizik,kimya,bio,adlar);
   		break;
   		case 3:
   		for(int i=1;i<=ogrsayi;i++)
   		{
   			if(bio[i]<60)
   			{
   				Console.WriteLine("Ögrenci No : {0}",numara[i]);
   				Console.WriteLine("Öğrenci Adı : {0}",adlar[i]);
   				Console.WriteLine("");
   				Console.WriteLine("");

   			}
   		}

   		//Console.ReadLine();
   		Menu(ogrsayi,numara,fizik,kimya,bio,adlar);
   		break;
   	}
   	Menu(ogrsayi,numara,fizik,kimya,bio,adlar);
   }
   public static float OrtalamaUstu(int ogrsayi,int [] numara,int [] fizik,int [] kimya,int [] bio,string [] adlar)
   {
   	float gecici5;
   	int secim3;
   	int temp = 0;
	Console.WriteLine("1 - Fizik Dersi Ortalamadan Yüksek Öğrenciler");
   	Console.WriteLine("2 - Kimya Dersi Ortalamadan Yüksek Öğrenciler");
   	Console.WriteLine("3 - Biyoloji Dersi Ortalamadan Yüksek Öğrenciler");
   	Console.WriteLine("Seçiminiz :");
   	secim3 = Convert.ToInt32(Console.ReadLine());
   	switch(secim3)
   	{
   	   	case 1:
   		for(int i=1;i<=ogrsayi;i++)
   		{
   			temp+= fizik[i];
   		}
   		for(int i=1;i<=ogrsayi;i++)
   		{
   		    if(((float)temp / ogrsayi) < fizik[i])
   		    {
   			Console.WriteLine("Ögrenci Numarası :"+numara[i]);
   			Console.WriteLine("Fizik Notu :"+fizik[i]);
   			Console.WriteLine("Kimya Notu :"+kimya[i]);
   			Console.WriteLine("Biyoloji Notu :"+bio[i]);
   			Console.WriteLine("");
   		    }
   	    }
   	
   		break;
   		case 2:
   		for(int i=1;i<=ogrsayi;i++)
   		{
   			kimya[i] += temp;
   		}
   		for(int i=1;i<=ogrsayi;i++)
   		{
   		    if(((float)temp / ogrsayi) < kimya[i])
   		    {
   			Console.WriteLine("Ögrenci Numarası :"+numara[i]);
   			Console.WriteLine("Fizik Notu :"+fizik[i]);
   			Console.WriteLine("Kimya Notu :"+kimya[i]);
   			Console.WriteLine("Biyoloji Notu :"+bio[i]);
   			Console.WriteLine("");
   		    }
   	    }
   		break;
   		case 3:
   		for(int i=1;i<=ogrsayi;i++)
   		{
   			bio[i] += temp;
   		}
   		
   		for(int i=1;i<=ogrsayi;i++)
   		{
   		    if(((float)temp / ogrsayi) < bio[i])
   		    {
   			Console.WriteLine("Ögrenci Numarası :"+numara[i]);
   			Console.WriteLine("Fizik Notu :"+fizik[i]);
   			Console.WriteLine("Kimya Notu :"+kimya[i]);
   			Console.WriteLine("Biyoloji Notu :"+bio[i]);
   			Console.WriteLine("");
   		    }
   	    }
   		break;
   	}

   	//Console.ReadLine();
   	Menu(ogrsayi,numara,fizik,kimya,bio,adlar);
   	return secim3;
   }

     public static int AltmısAltıSayac(int ogrsayi,int [] numara,int [] fizik,int [] kimya,int [] bio,string [] adlar)
   {
   	    int sayac = 0;
   		for(int i=1;i<=ogrsayi;i++)
   		{
   			if(fizik[i]<60)
   			{
   				sayac++;

   			}
   			if(kimya[i]<60)
   			{
   				sayac++;

   			}
   			if(bio[i]<60)
   			{
   				sayac++;

   			}
   		}
   		Console.WriteLine(sayac+ " tane 60 dan küçük not var");
   		//Console.ReadLine();
   		Menu(ogrsayi,numara,fizik,kimya,bio,adlar);
   		return sayac;

   	}

   	public static void EnYuksek(int ogrsayi,int [] numara,int [] fizik,int [] kimya,int [] bio,string [] adlar)
   {
   	int secim4;
   	int gecici;
    Console.WriteLine("1 - Fizik Dersi");
   	Console.WriteLine("2 - Kimya Dersi");
   	Console.WriteLine("3 - Biyoloji Dersi");
   	Console.WriteLine("Seçiminiz :");
   	secim4 = Convert.ToInt32(Console.ReadLine());
   	switch(secim4)
   	{
   	   case 1:
         int enbuyuk0 = fizik[0]; // En büyük sayı dizinin 0. terimi olsun
            for (int i = 1; i <= ogrsayi; i++) 
            {
              
                if (enbuyuk0 < fizik[i]) // Eğer dizideki değer en büyük değer ise
                {
                    enbuyuk0 = fizik[i]; // En büyük değer olarak işaretle
                }
            }
      Console.WriteLine("\nEn Yüksek Fizik Notu = " + (enbuyuk0));
        break;
   	    case 2:
           int enbuyuk1 = kimya[0];
            for (int i = 1; i <= ogrsayi; i++)
            {
                
                if (enbuyuk1 < kimya[i])
                {
                    enbuyuk1 = kimya[i];
                }
            }
      Console.WriteLine("\nEn Yüksek Kimya Notu = " + (enbuyuk1));
   		break;
   		case 3:
   		    int enbuyuk2 = bio[0];
            for (int i = 1; i <= ogrsayi; i++)
            {
                
                if (enbuyuk2 < bio[i])
                {
                    enbuyuk2 = bio[i];
                }
            }
      Console.WriteLine("\nEn Yüksek Biyoloji Notu = " + (enbuyuk2));
   		break;
   	}

    //Console.ReadLine();
   	Menu(ogrsayi,numara,fizik,kimya,bio,adlar);
   }
   	
   	public static void EnDusuk(int ogrsayi,int [] numara,int [] fizik,int [] kimya,int [] bio,string [] adlar)
   {
   	int secim5;
   	int gecici;
    Console.WriteLine("1 - Fizik Dersi");
   	Console.WriteLine("2 - Kimya Dersi");
   	Console.WriteLine("3 - Biyoloji Dersi");
   	Console.WriteLine("Seçiminiz :");
   	secim5 = Convert.ToInt32(Console.ReadLine());	
   	switch(secim5)
   	{
   	   case 1:
         int enkucuk1 = fizik[1]; // En küçük sayı dizinin 1. terimi olsun
            for (int i = 1; i <= ogrsayi; i++)
            {
                
                if (fizik[i] < enkucuk1)// Eğer dizideki değer en küçük değer ise
                {
                    enkucuk1 = fizik[i];// En küçük değer olarak işaretle
                }
            }
      Console.WriteLine("\nEn Düşük Fizik Notu = " + (enkucuk1));
        break;
   	    case 2:
           int enkucuk2 = kimya[1]; 
            for (int i = 1; i <= ogrsayi; i++)
            {
                
                if (kimya[i] < enkucuk2	)
                {
                    enkucuk2 = kimya[i];
                }
            }
      Console.WriteLine("\nEn Düşük Kimya Notu = " + (enkucuk2));
   		break;
   		case 3:
   		    int enkucuk3 = bio[1];
            for (int i = 1; i <= ogrsayi; i++)
            {
               
                if (bio[i] < enkucuk3)
                {
                    enkucuk3 = bio[i];
                }
            }
      Console.WriteLine("\nEn Düşük Biyoloji Notu = " + (enkucuk3));
   		break;
   	}

   	//Console.ReadLine();
   	Menu(ogrsayi,numara,fizik,kimya,bio,adlar);
   }
   public static float OrtalamaSırala(int ogrsayi,int [] numara,int [] fizik,int [] kimya,int [] bio,string [] adlar)
   {
   	float gecici1;
   	  int[] temp1 = new int[300];
   	  int[] temp2 = new int[300];
   	  int[] temp3 = new int[300];
   	  float[] temp4 = new float[300];
   	  string temp5;
   	  int temp6;
   	  int temp7;
   	  int temp8;
   	  int temp9;
      for(int i = 1 ; i<= ogrsayi ; i++)
      {
      	temp1[i] = fizik[i];
      	temp2[i] = kimya[i];
      	temp3[i] = bio[i];
      	temp4[i] = (temp1[i] + temp2[i] + temp3[i])/3;
      }
      int gecici = 0;
 
            for     (int i = 0; i < numara.Length-1; i++)
            {
                for (int j = i + 1; j < numara.Length;j++)                 
                {                     
                    if (temp4[j] > temp4[i])
                    {
                        temp6 = numara[j];
                        numara[j] = numara[i];
                        numara[i] = temp6;
                        temp7 = fizik[j];
                        fizik[j] = fizik[i];
                        fizik[i] = temp7;
                        temp8 = kimya[j];
                        kimya[j] = kimya[i];
                        kimya[i] = temp8;
                        temp9 = bio[j];
                        bio[j] = bio[i];
                        bio[i] = temp9;
                        temp5 = adlar[j];
                        adlar[j] = adlar[i];
                        adlar[i] = temp5;

                    }
                }
            }
 
            for (int a = 0; a <= ogrsayi; a++)
            {
                Console.WriteLine("Numarası :"+numara[a]);
                Console.WriteLine("Adı :"+adlar[a]);
                Console.WriteLine("Fizik Notu :"+fizik[a]);
                Console.WriteLine("Kimya Notu :"+kimya[a]);
                Console.WriteLine("Biyoloji Notu :"+bio[a]);
                Console.WriteLine("");
            }
            Console.ReadLine();
            Menu(ogrsayi,numara,fizik,kimya,bio,adlar);
            return gecici;
   }
   public static int NumaraSırala(int ogrsayi,int [] numara,int [] fizik,int [] kimya,int [] bio,string [] adlar)
   {
   	        int yedek = 0;
   	        string yedek1;
   	        int yedek2 = 0;
   	        int yedek3 = 0;
   	        int yedek4 = 0;
 
            for   (int i = 0; i < ogrsayi-1; i++)
            {
                for (int j = i + 1; j<ogrsayi;j++)                 
                {                     
                    if (numara[j] < numara[i])
                    {
                        yedek = numara[j];
                        numara[j] = numara[i];
                        numara[i] = yedek;
                        yedek1 = adlar[j];
                        adlar[j] = adlar[i];
                        adlar[i] = yedek1;
                        yedek2 = fizik[j];
                        fizik[j] = fizik[i];
                        fizik[i] = yedek2;
                        yedek3 = kimya[j];
                        kimya[j] = kimya[i];
                        kimya[i] = yedek3;
                        yedek4 = bio[j];
                        bio[j] = bio[i];
                        bio[i] = yedek4;

                        }
                    }
                }
            for (int a = 0; a <= ogrsayi; a++)
            {
            	Console.WriteLine("");
                Console.WriteLine("Numarası :"+numara[a]);
                Console.WriteLine("Adı :"+adlar[a]);
                Console.WriteLine("Fizik Notu :"+fizik[a]);
                Console.WriteLine("Kimya Notu :"+kimya[a]);
                Console.WriteLine("Biyoloji Notu :"+bio[a]);
                Console.WriteLine("");
            }
 
            
   		    //Console.ReadLine();
            Menu(ogrsayi,numara,fizik,kimya,bio,adlar);
            return ogrsayi;
}
}