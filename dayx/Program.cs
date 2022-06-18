// See https://aka.ms/new-console-template for more information
Console.WriteLine("welcome to employee wage computation program");
Random random = new Random();
int res = random.Next(0, 2);
Console.WriteLine(res);
const int wageperhour = 20, dayhour = 8, parttimehour=4;
if(res==1)
{
    Console.WriteLine("present");
    Console.WriteLine("dailywage:"+ (wageperhour * dayhour));
    Console.WriteLine("parttime wage:" + (wageperhour * parttimehour));
}
else
{
    Console.WriteLine("absent");
}
