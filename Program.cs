class StopWatch
{
  public static void Main(string[] args)
  {
    Menu();
  }
  static void Menu()
  {
    Console.Clear();
    Console.WriteLine(value: "S = Segundo => 10s = 10 segundos");
    Console.WriteLine(value: "M = Minuto => 1m = 1 minuto");
    Console.WriteLine(value: "0 = Sair");
    Console.WriteLine(value: "Quanto tempo deseja contar?");
    string data = Console.ReadLine().ToLower();
    char type = char.Parse(s: data.Substring(startIndex: data.Length - 1, length: 1));
    int time = int.Parse(s: data.Substring(startIndex: 0, length: data.Length - 1));
    int multiplier = 1;

    if (type == 'm')
    {
      multiplier = 60;
    }
    else if (type == 's')
    {
      multiplier = 1;
    }

    if (time == 0)
      System.Environment.Exit(exitCode: 0);

    PreStart(time: time * multiplier);

  }
  static void PreStart(int time)
  {
    Console.Clear();
    Console.WriteLine(value: "Ready...");
    Thread.Sleep(millisecondsTimeout: 1000);
    Console.WriteLine(value: "Set...");
    Thread.Sleep(millisecondsTimeout: 1000);
    Console.WriteLine(value: "Go...");
    Thread.Sleep(millisecondsTimeout: 1000);

    Start(time: time);
  }
  static void Start(int time)
  {

    int currentTime = 0;
    while (currentTime != time)
    {
      Console.Clear();
      currentTime++;
      Console.WriteLine(value: currentTime);
      Thread.Sleep(millisecondsTimeout: 1000);
    }
    Console.Clear();
    Console.WriteLine(value: "Stopwatch finalizado!");
    Thread.Sleep(millisecondsTimeout: 2500);
    Menu();

  }
}