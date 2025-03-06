using System.Data;
using LR3;
using static System.Console;

static void Task1()
{
    Date first = new Date(27, 01, 2025);
    Date second = new Date(14, 2, 1403);


    first.PrintTemplate1();
    second.PrintTemplate2();

    first.CorrectDate();

    second.Century();

    first.CountDayBetweenTwoDate(second);
}

static void Task2()
{
    Company[] companies = new Company[3];

    companies[0] = new InsuranceCompany("Insurance your life", "Cars and vehicle");
    companies[1] = new OilCompany("British Petrolium", 30.5);
    companies[2] = new Factory("Audi automobile factory", "Automobile manufacture");
        
    foreach(Company company in companies) 
    {
        company.Show();
    }
}

Task2();
