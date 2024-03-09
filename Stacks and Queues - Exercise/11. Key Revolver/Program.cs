namespace _11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] inputBullets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] inputLocks = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int intelligence = int.Parse(Console.ReadLine());

            Queue<int> locks = new Queue<int>(inputLocks);
            Stack<int> bullets = new Stack<int>(inputBullets);
            int bulletsShot = 0;
            int tempGunBarrel = gunBarrelSize;

            while (bullets.Count > 0 && locks.Count > 0)
            {

                int currentBullet = bullets.Pop();
                bulletsShot++;
                tempGunBarrel--;

                if (currentBullet <= locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (tempGunBarrel == 0 && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    tempGunBarrel = gunBarrelSize;
                }
            }

            if (bullets.Count == 0 && locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int moneyEarned = intelligence - (bulletsShot * bulletPrice);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
        }
    }
}