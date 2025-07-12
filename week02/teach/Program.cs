using System;

Console.WriteLine("\n======================\nCustomer Service\n======================");
CustomerService.Run();
//CustomerServiceSolution.Run();

Console.WriteLine("\n======================\nComplex Stack\n======================");
Console.WriteLine(ComplexStack.DoSomethingComplicated("(a == 3 or (b == 5 and c == 6))"));
Console.WriteLine(ComplexStack.DoSomethingComplicated("(students]i].Grade > 80 and students[i].Grade < 90"));
Console.WriteLine(ComplexStack.DoSomethingComplicated("(robot[id + 1].Execute(.Pass() || (!robot[id * (2 + i)].Alive && stormy) || (robot[id - 1].Alive && lavaFlowing))"));
