// Flip Coin and print percentage of Heads and Tails

int Head = 0;

Random prob = new Random();

int Flip = prob.Next(0, 2);

if (Head < 0.5)
{
    Console.WriteLine("Probability to get Head");

}
else
{
    Console.WriteLine("Probability to get Tail");
}
