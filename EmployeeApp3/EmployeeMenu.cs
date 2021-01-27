using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp3
{
	class EmployeeMenu
	{
		static void Main(string[] args)
		{
			   
			int Checker = 1;

			bool flag = true;
			IDictionary<int, Tuple<string, int, double>> employees = new Dictionary<int, Tuple<string, int, double>>();
			Employee em = new Employee();
			
				while (flag)
				{


					em.DisplayMenu();
					int ch = Int32.Parse(Console.ReadLine());



					switch (ch)
					{
						//Add employee
						case 1:
							{
								try
								{
									do
									{
										em.TakeEmployeeDetailsFromUser();

										employees.Add(em.Id, Tuple.Create(em.Name, em.Age, em.Salary));
										Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
										Checker = Convert.ToInt32(Console.ReadLine());
									} while (Checker == 1);
								}
								catch (Exception ex)
								{
									Console.WriteLine("------Give proper Input-------", ex);
								}


							}
							break;



						//Modify employee
						case 2:
							{

								try
								{
									Console.WriteLine("Please enter the employee ID");
									int id1 = Convert.ToInt32(Console.ReadLine());



									foreach (var obj in employees)
									{

										if (obj.Key == id1)
										{

											Console.WriteLine("Employee ID:{0}\nName:{1}\nAge:{2}\nSalary:{3}", obj.Key, obj.Value.Item1, obj.Value.Item2, obj.Value.Item3);

											break;
										}
										if (obj.Key != id1)
										{
											Console.WriteLine("Please give the correct employee ID that you want to modify");
											Console.WriteLine("---------------");
											goto case 2;


										}


									}


									employees.Remove(id1);

									Console.WriteLine("Please enter the updated employee details");
									em.TakeEmployeeDetailsFromUser();
									employees.Add(em.Id, Tuple.Create(em.Name, em.Age, em.Salary));
								}
								catch (Exception e)
								{
									Console.WriteLine("Give EmployeeID as Numbers", e.Message);
								}

							}
							break;


						//print all employees info
						case 3:
							{
								foreach (var obj in employees)
								{

									Console.WriteLine("Employee ID:{0}\nName:{1}\nAge:{2}\nSalary:{3}", obj.Key, obj.Value.Item1, obj.Value.Item2, obj.Value.Item3);
									Console.WriteLine("----------------------------------");
								}

							}
							break;
						//print  specific employee info
						case 4:
							{
								try
								{
									Console.WriteLine("Please enter the employee ID");
									int id1 = Convert.ToInt32(Console.ReadLine());


									foreach (var obj in employees)
									{
										if (obj.Key == id1)
										{

											Console.WriteLine("Employee ID:{0}\nName:{1}\nAge:{2}\nSalary:{3}", obj.Key, obj.Value.Item1, obj.Value.Item2, obj.Value.Item3);
										Console.WriteLine("----------------------------------");
										break;

										}
										else
										{
											Console.WriteLine("Please give the correct employee ID that you want to See");
											Console.WriteLine("--------------------");
											break;
										}


									}
								}
								catch (Exception e)
								{
									Console.WriteLine("Give EmployeeID as Numbers", e.Message);
								}
							}
							break;


						//exit.
						case 5:
							{ flag = false; }
							break;

						default:
							{

								Console.WriteLine("-----Please give correct input as given above------");

							}
							break;
					}
				}
		}



    }
		
}
	

