Console.WriteLine("sno.\t\tCelcius\t\tFahrenheit ");

  for (int i=1, C = 0; i<=10; i++, C = C + 10)
  {
    int F = ((C * 9) / 5) + 32;
    Console.WriteLine($" {i}\t\t{C}\t\t{F}");
  }