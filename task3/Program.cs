

  Console.WriteLine("input number");
  int number = int.Parse(Console.ReadLine());

  int[] array = new int[number];

  for (int i = 0; i < number; i++)
  {
    array[i] = new Random().Next(number+1);
    Console.Write(array[i] + " ");
  }
 Console.WriteLine();
