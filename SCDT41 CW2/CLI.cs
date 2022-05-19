using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharprompt;
using static SCDT41_CW2.Enums;

namespace SCDT41_CW2
{
    internal class CLI
    {
        static void Main(string[] args)
        {
            List<TimeLog> timelog = new List<TimeLog>();
            List<Commercial> commercial = new List<Commercial>();
            List<Domestic> doemstic = new List<Domestic>();
            List<CosmeticService> cosmeticService = new List<CosmeticService>();
            List<ProblemService> problemService = new List<ProblemService>();


            Menu(timelog);
            static void Menu(List<TimeLog> timelog)
            {
                Console.Clear();
                var menuSelection = Prompt.Select("Main Menu", new[] { "Book Service", "Update Service", "View Timelog", "Purchase Materials", "Quit" });
                switch (menuSelection)
                {
                    case ("Add Property"):
                        AddProperty();
                        Console.Clear();
                        break;
                    case ("Book Service"):
                        BookService();
                        Console.Clear();
                        break;
                    case ("Update Service"):
                        UpdateService();
                        Console.Clear();
                        break;
                    case ("View Timelog"):
                        ViewTimelog(timelog);
                        Console.Clear();
                        break;
                    case ("Purchase Materials"):
                        PurchaseMaterials();
                        Console.Clear();
                        break;
                    case ("Quit"):
                        Quit();
                        break;
                }
            }



            static void AddProperty()
            {
                string correctInfo = "Yes";

                while (correctInfo == "Yes")
                {
                    var propertyType = Prompt.Select("Select property type", new[] { "Commercial", "Domestic" });
                    if (propertyType == "Commercial")
                    {
                        string address = Prompt.Input<string>("Enter the property address");
                        string nameOfBusiness = Prompt.Input<string>("Enter the name of the business");
                        CommercialProperty type = Prompt.Select<CommercialProperty>("Select the property type:", new[] { CommercialProperty.OFFICE, CommercialProperty.HOTEL, CommercialProperty.WAREHOUSE, CommercialProperty.STORE });
                        double sizeInMeters = Prompt.Input<double>("Enter the property size in meters");
                        string fname = Prompt.Input<string>("Enter the customers first name");
                        string lname = Prompt.Input<string>("Enter the customers last name");

                        
                    }
                    else
                    {

                    }

                    correctInfo = Prompt.Select("Are you sure these details correct", new[] { "No", "Yes" });
                }

            }


            static void BookService()
            {
                string correctInfo = "Yes";

                while (correctInfo == "Yes")
                {
                    var serviceType = Prompt.Select("Select service type", new[] { "Cosmetic", "Problem" });
                    if (serviceType == "Cosmetic")
                    {
                        string description = Prompt.Input<string>("Enter the service descripton");
                        string isOpen = Prompt.Select<string>("Is the iss")
                    }
                    else
                    {

                    }

                    correctInfo = Prompt.Select("Are you sure these details correct", new[] { "No", "Yes" });
                }
                    



                
            }
            static void UpdateService()
            {

            }



            static void ViewTimelog(List<TimeLog> timelog)
            {
                Console.WriteLine(timelog);
            }



            static void PurchaseMaterials()
            {
                string correctInfo = "Yes";
                while (correctInfo == "Yes")
                {
                    string description = Prompt.Input<string>("Enter the description of the products needed");
                    double cost = Prompt.Input<double>("Purchase cost");

                    correctInfo = Prompt.Select("Are you sure these details correct", new[] { "No", "Yes" });
                }
                
            }



            static void Quit()
            {

            }
        }
    }
}
