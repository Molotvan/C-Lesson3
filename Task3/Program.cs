Random random = new Random();
int N = random.Next(1, 10);
Console.WriteLine(N);
Console.WriteLine();
for(int i = 1; i <= N; i++){
Console.WriteLine(Math.Pow((i), 3));
}