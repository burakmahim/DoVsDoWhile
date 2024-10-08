// while
Console.WriteLine("bir sayı giriniz: ");
string limit1 = Console.ReadLine();
bool islimit1= int.TryParse(limit1, out int limit1Value);

int sayac1 = 0;
while (sayac1 <= limit1Value)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac1++;
}

//do-while
Console.WriteLine("bir sayı giriniz: ");
string limit2 = Console.ReadLine();
bool islimit2 = int.TryParse(limit2, out int limit2Value);

int sayac2 = 0;

do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac2++;
} while (sayac2 <= limit2Value);

//while' da kullanıcı (-) bir değer girerse eğer döngüye hiç girmeden bitecek yani ekranda hiç Ben bir Patika'lıyım yazmayacak.

// do-while'da kullanıcı (-) bir değer girse bile döngü bir kere çalışacak ve erkana Ben bir Patika'lıyım yazdıracak.