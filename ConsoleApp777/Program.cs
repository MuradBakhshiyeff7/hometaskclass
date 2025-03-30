namespace ConsoleApp777
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon(30, 10, false);
            while (true)
            {
                Console.WriteLine("0 - İnformasiya almaq üçün");
                Console.WriteLine("1 - Shoot");
                Console.WriteLine("2 - GetRemainBulletCount");
                Console.WriteLine("3 - Reload");
                Console.WriteLine("4 - ChangeFireMode");
                Console.WriteLine("5 - Proqramdan çıxmaq");
                Console.Write("Seçiminizi daxil edin: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                    Console.WriteLine("Bu proqram silahın funksiyalarını sınaqdan keçirmək üçündür.");
                else if (choice == 1)
                    weapon.Shoot();
                else if (choice == 2)
                    Console.WriteLine($"Daraq doldurmaq üçün {weapon.GetRemainBulletCount()} güllə lazımdır.");
                else if (choice == 3)
                    weapon.Reload();
                else if (choice == 4)
                    weapon.ChangeFireMode();
                else if (choice == 5)
                    break;
                else
                    Console.WriteLine("Yanlış seçim!");
            }
        }

        class Weapon
        {
            private int magazineCapacity;
            private int bulletsInMagazine;
            private bool isAutomatic;

            public Weapon(int capacity, int bullets, bool automatic)
            {
                if (capacity <= 0 || bullets < 0 || bullets > capacity)
                {
                    Console.WriteLine("Yanlış dəyərlər daxil edilib!");
                    return;
                }
                magazineCapacity = capacity;
                bulletsInMagazine = bullets;
                isAutomatic = automatic;
            }

            public void Shoot()
            {
                if (bulletsInMagazine == 0)
                {
                    Console.WriteLine("Daraq boşdur!");
                    return;
                }
                if (isAutomatic)
                {
                    Console.WriteLine($"Avtomatik atış: {bulletsInMagazine} güllə atıldı!");
                    bulletsInMagazine = 0;
                }
                else
                {
                    Console.WriteLine("Təkli atış: 1 güllə atıldı!");
                    bulletsInMagazine--;
                }
            }

            public int GetRemainBulletCount()
            {
                return magazineCapacity - bulletsInMagazine;
            }

            public void Reload()
            {
                int neededBullets = GetRemainBulletCount();
                bulletsInMagazine += neededBullets;
                Console.WriteLine($"Daraq dolduruldu! {neededBullets} güllə əlavə edildi.");
            }

            public void ChangeFireMode()
            {
                isAutomatic = !isAutomatic;
                Console.WriteLine($"Atış modu dəyişdirildi: {(isAutomatic ? "Avtomatik" : "Təkli")}.");
            }
        }
    }
    

}
