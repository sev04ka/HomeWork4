Console.Write("x  ");
Console.Write("y  ");
Console.Write("z  ");
Console.WriteLine("F  ");



for (int x = 0; x < 2; x++)
{
    for (int y = 0; y < 2; y++)
    {   
        for (int z = 0; z < 2; z++)
        {
            if ((x == 1 & y == 1) | (y == 1 & z != y) | x == 1)
            {
                Console.WriteLine($"{x}  {y}  {z}  1  ");
            }
            else
            {
                Console.WriteLine($"{x}  {y}  {z}  0  ");
            }

        }
    }
}