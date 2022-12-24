// See https://aka.ms/new-console-template for more information


using Domain.Models.ListModels;
using Service.Controllers;

#region Check Login
LoginController.CheckLoginInput();
#endregion

#region Check Factorial
FactorialController.CheckFactorial();
#endregion

#region Cutom List Methods 
MyList<int> list = new MyList<int>();
list.Add(3);
list.Add(7);
list.Add(2);
list.Add(1);
list.Add(7);

MyList<int> list2 = new MyList<int>();
list2.Add(3);
list2.Add(7);
list2.Add(2);
list2.Add(1);
list2.Add(7);

Console.WriteLine(list.Find(a => a < 2));
Console.WriteLine(list.FindAll(a => a >5));
list.Clear();

#endregion

