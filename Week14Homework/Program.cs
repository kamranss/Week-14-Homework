// See https://aka.ms/new-console-template for more information


using Domain.Models.ListModels;
using Service.Controllers;

#region Check Login
LoginController.CheckLoginInput();
#endregion

#region Check Factorial
FactorialController.CheckFactorial();
#endregion

#region Add To Generic List
MyList<int> list = new MyList<int>();
list.Add(7);
list.Add(7);
list.Add(7);
list.Add(7);
list.Add(7);
#endregion

