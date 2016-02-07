using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxtester
{


    class Boxtester
    {

        static void Main(string[] args)
        {
    
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Merhaba Çağrının KPSS Destek Uygulamasına Hoş Geldiniz");
                Console.WriteLine("");
                Console.WriteLine("1. Kutunun Hesapları");
                Console.WriteLine("2. Hesap Makinası");
                Console.WriteLine("3. Kutunun Ağırlık");
                Console.WriteLine("4. Kare Alan");
                Console.WriteLine("5. Array Try Catch");
                //drLabel:

                //    try { }
                //    catch (Exception ex) { Console.WriteLine("Error: {0}", ex.Message); goto drLabel; }

                int grade = int.Parse(Console.ReadLine());
                if (grade == 1 || grade == 2 || grade == 3 || grade == 4 || grade == 5)
                {

                    switch (grade)
                    {

                        case 1:
                        drLabel:
                            Console.WriteLine("");
                            Console.WriteLine("Merhaba, toplamda 3 değer girin.");
                            string[] answer = new string[3];
                            for (int i = 0; i < answer.Length; i++)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Bir değer gireceksiniz");
                                answer[i] = Console.ReadLine();
                                if (string.IsNullOrEmpty(answer[i])) {
                                    Console.WriteLine("Hatalı bir değer girdiniz, lütfen düzgün bir değer giriniz");
                                    answer[i] = "";
                                    goto drLabel;
                                }
                            }
                            Console.ReadKey();
                            boxT b = new boxT();
                            b.boxThings(double.Parse(answer[0]), double.Parse(answer[1]), double.Parse(answer[2]));
                            break;

                        case 2:

                            calculations calculate = new calculations();

                            Console.WriteLine("Lütfen 4 işlemden birini seçiniz.");
                            Console.WriteLine("1.Toplama");
                            Console.WriteLine("2.Çıkarma");
                            Console.WriteLine("3.Carpma");
                            Console.WriteLine("4.Bolme");

                            int switcher = int.Parse(Console.ReadLine());

                            Console.Write("İlk Sayıyı Giriniz");
                            int ilkSayi = int.Parse(Console.ReadLine());
                            Console.Write("İkinci Sayıyı Giriniz");
                            int ikinciSayi = int.Parse(Console.ReadLine());

                            if (switcher == 1)
                            {
                                Console.WriteLine("Sonuç");
                                Console.WriteLine(calculate.addNum(ilkSayi, ikinciSayi));
                            }
                            else if (switcher == 2)
                            {
                                Console.WriteLine("Sonuç");
                                Console.WriteLine(calculate.sumNum(ilkSayi, ikinciSayi));
                            }
                            else if (switcher == 3)
                            {
                                Console.WriteLine(calculate.carpNum(ilkSayi, ikinciSayi));
                            }
                            else if (switcher == 4)
                            {
                                Console.WriteLine(calculate.bolNum(ilkSayi, ikinciSayi));
                            }
                            else {
                                Console.WriteLine("Lütfen düzgün seçim yapınız!!");
                            }
                            break;

                        case 3:
                            Console.WriteLine("Burda Kutunun Ağırlığını Hesaplayacağız");
                            Console.Write("Lütfen bir değer giriniz");
                            boxT agirlik = new boxT();
                            agirlik.setWeight(int.Parse(Console.ReadLine()));
                            Console.WriteLine(agirlik.getWeight());
                            break;

                        case 4:
                            Console.WriteLine("Burda karenin ağırlığını hesaplayacağız.");
                            Kare kareHes = new Kare();
                            Console.Write("Yükseklik girin:");
                            kareHes.setHeight(int.Parse(Console.ReadLine()));
                            Console.Write("En girin:");
                            kareHes.setWidth(int.Parse(Console.ReadLine()));
                            Console.WriteLine(kareHes.kareAlan());
                            Console.ReadKey();
                            break;

                        case 5:
                            Console.WriteLine("2 değerli arraya 3 değer sokarsan");
                            trcaDeneme arrL = new trcaDeneme();
                            arrL.arrLi();
                            break;
                    }

                }
                else {
                    Console.WriteLine("Lütfen 1 yada 2 seçeneklerinden birini seçiniz!!");
                    Console.ReadKey();
                }

                
            }
            
        }
    }

}
