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
            List<TimeLlog> TimelogList = new List<TimeLlog>();
            List<Commercial> CommercialList = new List<Commercial>();
            List<Domestic> DomesticList = new List<Domestic>();
            List<CosmeticService> CosmeticList = new List<CosmeticService>();
            List<ProblemService> ProblemList = new List<ProblemService>();
            List<Purchase> PurchaseList = new List<Purchase>();
            List<Customer> CustomerList = new List<Customer>();
            List<TeamMember> TeamMemberList = new List<TeamMember>();


            TeamMember bob = new TeamMember("Bob", "Bobbington", "Bob123", "Password123", EmployeeType.ADMIN);
            TeamMemberList.Add(bob);
            Customer mark = new Customer("mark", "spencer");
            CustomerList.Add(mark);



            Menu(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
            static void Menu(List<TimeLlog> TimelogList, List<Commercial> CommercialList, List<Domestic> DomesticList, List<Customer> CustomerList, List<CosmeticService> CosmeticList, List<ProblemService> ProblemList, List<Purchase> PurchaseList, List<TeamMember> TeamMemberList)
            {
                var menuSelection = Prompt.Select("Main Menu", new[] { "Add Property", "Edit Property", "Add Customer", "Edit Customer", "Add Service", "Edit Service", "Add Staff", "Edit Staff", "Purchase Materials", "View Purchases", "Add Timelog", "View Timelog", "Quit" });
                switch (menuSelection)
                {
                    case ("Add Property"):
                        AddProperty(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                        break;
                    case ("Edit Property"):
                        EditProperty(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                        break;
                    case ("Add Customer"):
                        AddCustomer(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                        break;
                    case ("Edit Customer"):
                        EditCustomer(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                        break;
                    case ("Add Service"):
                        AddService(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                        break;
                    case ("Edit Service"):
                        EditService(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                        break;
                    case ("Add Staff"):
                        AddStaff(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                        break;
                    case ("Edit Staff"):
                        EditStaff(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                        break;
                    case ("Purchase Materials"):
                        PurchaseMaterials(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                        break;
                    case ("View Purchases"):
                        ViewPurchases(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                        break;
                    case ("Add Timelog"):
                        AddTimelog(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                        break;
                    case ("View Timelog"):
                        ViewTimelog(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                        break;
                    case ("Quit"):
                        Quit();
                        break;
                }
            }



            static void AddProperty(List<TimeLlog> TimelogList, List<Commercial> CommercialList, List<Domestic> DomesticList, List<Customer> CustomerList, List<CosmeticService> CosmeticList, List<ProblemService> ProblemList, List<Purchase> PurchaseList, List<TeamMember> TeamMemberList)
            {
                var propertyType = Prompt.Select("Select property type", new[] { "Commercial", "Domestic" });
                if (propertyType == "Commercial")
                {
                    string address = Prompt.Input<string>("Enter the property address");
                    string nameOfBusiness = Prompt.Input<string>("Enter the name of the business");
                    CommercialProperty type = Prompt.Select<CommercialProperty>("Select the property type", new[] { CommercialProperty.OFFICE, CommercialProperty.HOTEL, CommercialProperty.WAREHOUSE, CommercialProperty.STORE });
                    double sizeInMeters = Prompt.Input<double>("Enter the property size in meters");


                    string[] customers = { };
                    foreach (Customer i in CustomerList)
                    {
                        customers.ToArray();
                    }
                    Customer owner = Prompt.Select("Select the customer", CustomerList);


                    string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                    bool checkInfo = ConvertToBool(correctInfo);
                    if (checkInfo)
                    {
                        Commercial tempCommercial = new Commercial(address, nameOfBusiness, type, sizeInMeters, owner);
                        CommercialList.Add(tempCommercial);
                    }
                    Menu(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                }
                else
                {
                    string address = Prompt.Input<string>("Enter the property address");
                    DomesticProperty type = Prompt.Select<DomesticProperty>("Select the property type", new[] { DomesticProperty.DETACHED, DomesticProperty.SEMI_DETACHED, DomesticProperty.FLAT, DomesticProperty.BUNGALOW, DomesticProperty.COTTAGE });
                    int numberOfBedrooms = Prompt.Input<int>("Enter the number of bedrooms");


                    string[] customers = { };
                    foreach (Customer i in CustomerList)
                    {
                        customers.ToArray();
                    }
                    Customer owner = Prompt.Select("Select the customer", CustomerList);


                    string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                    bool checkInfo = ConvertToBool(correctInfo);
                    if (checkInfo)
                    {
                        Domestic tempDomestic = new Domestic(address, type, numberOfBedrooms, owner);
                        DomesticList.Add(tempDomestic);

                        Menu(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                    }
                }
            }



            static void EditProperty(List<TimeLlog> TimelogList, List<Commercial> CommercialList, List<Domestic> DomesticList, List<Customer> CustomerList, List<CosmeticService> CosmeticList, List<ProblemService> ProblemList, List<Purchase> PurchaseList, List<TeamMember> TeamMemberList)
            {
                string[] properties = { };

                var propertyType = Prompt.Select("Select property type", new[] { "Commercial", "Domestic" });
                if (propertyType == "Commercial")
                {
                    foreach (Commercial i in CommercialList)
                    {
                        properties.ToArray();
                    }


                    Commercial editProperty = Prompt.Select("Select the property to edit", CommercialList);
                    foreach (Commercial i in CommercialList)
                    {
                        if (i == editProperty)
                        {
                            string address = Prompt.Input<string>("Enter the property address");
                            string nameOfBusiness = Prompt.Input<string>("Enter the name of the business");
                            CommercialProperty type = Prompt.Select<CommercialProperty>("Select the property type", new[] { CommercialProperty.OFFICE, CommercialProperty.HOTEL, CommercialProperty.WAREHOUSE, CommercialProperty.STORE });
                            double sizeInMeters = Prompt.Input<double>("Enter the property size in meters");


                            string[] customers = { };
                            foreach (Customer j in CustomerList)
                            {
                                customers.ToArray();
                            }
                            Customer owner = Prompt.Select("Select the customer", CustomerList);


                            string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                            bool checkInfo = ConvertToBool(correctInfo);
                            if (checkInfo)
                            {
                                i.Address = address;
                                i.NameOfBusiness = nameOfBusiness;
                                i.PropertyType = type;
                                i.SizeInMeters = sizeInMeters;
                                i.CurrentOwner = owner;
                            }
                            Menu(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                        }
                    }
                }
                else
                {
                    foreach (Domestic i in DomesticList)
                    {
                        properties.ToArray();
                    }


                    Domestic editProperty = Prompt.Select("Select the property to edit", DomesticList);
                    foreach (Domestic property in DomesticList)
                    {
                        if (property == editProperty)
                        {
                            string address = Prompt.Input<string>("Enter the property address");
                            DomesticProperty type = Prompt.Select<DomesticProperty>("Select the property type", new[] { DomesticProperty.DETACHED, DomesticProperty.SEMI_DETACHED, DomesticProperty.FLAT, DomesticProperty.BUNGALOW, DomesticProperty.COTTAGE });
                            int numberOfBedrooms = Prompt.Input<int>("Enter the number of bedrooms");


                            string[] customers = { };
                            foreach (Customer i in CustomerList)
                            {
                                customers.ToArray();
                            }
                            Customer owner = Prompt.Select("Select the customer", CustomerList);


                            string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                            bool checkInfo = ConvertToBool(correctInfo);
                            if (checkInfo)
                            {
                                property.Address = address;
                                property.PropertyType = type;
                                property.NumberOfBedrooms = numberOfBedrooms;
                            }
                            Menu(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                        }
                    }
                }
            }



            static void AddCustomer(List<TimeLlog> TimelogList, List<Commercial> CommercialList, List<Domestic> DomesticList, List<Customer> CustomerList, List<CosmeticService> CosmeticList, List<ProblemService> ProblemList,List<Purchase> PurchaseList, List<TeamMember> TeamMemberList)
            {
                while (true)
                {
                    string fname = Prompt.Input<string>("Enter the customer's first name");
                    string lname = Prompt.Input<string>("Enter the customer's last name");

                    string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                    bool checkInfo = ConvertToBool(correctInfo);
                    if (checkInfo)
                    {
                        Customer tempCustomer = new Customer(fname, lname);
                        CustomerList.Add(tempCustomer);

                        Menu(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                    }
                }
            }

            static void EditCustomer(List<TimeLlog> TimelogList, List<Commercial> CommercialList, List<Domestic> DomesticList, List<Customer> CustomerList, List<CosmeticService> CosmeticList, List<ProblemService> ProblemList, List<Purchase> PurchaseList, List<TeamMember> TeamMemberList)
            {
                string[] customers = { };

                foreach (Customer i in CustomerList)
                {
                    customers.ToArray();
                }


                Customer editCustomer = Prompt.Select("Select the customer to edit", CustomerList);
                foreach (Customer customer in CustomerList)
                {
                    if (customer == editCustomer)
                    {
                        string fname = Prompt.Input<string>("Enter the customer's first name");
                        string lname = Prompt.Input<string>("Enter the customer's last name");

                        string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                        bool checkInfo = ConvertToBool(correctInfo);
                        if (checkInfo)
                        {
                            customer.Fname = fname;
                            customer.Lname = lname;
                        }
                        Menu(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                    }
                }
            }



            static void AddService(List<TimeLlog> TimelogList, List<Commercial> CommercialList, List<Domestic> DomesticList, List<Customer> CustomerList, List<CosmeticService> CosmeticList, List<ProblemService> ProblemList, List<Purchase> PurchaseList, List<TeamMember> TeamMemberList)
            {
                var serviceType = Prompt.Select("Select service type", new[] { "Cosmetic", "Problem" });
                if (serviceType == "Cosmetic")
                {
                    string description = Prompt.Input<string>("Enter the service descripton");

                    string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                    bool checkInfo = ConvertToBool(correctInfo);
                    if (checkInfo)
                    {
                        CosmeticService tempService = new CosmeticService(description);
                        CosmeticList.Add(tempService);
                    }
                    Menu(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                }
                else
                {
                    string description = Prompt.Input<string>("Enter the service descripton");
                    SeverityPriority severityPriority = Prompt.Select<SeverityPriority>("Select the severity of the issue", new[] { SeverityPriority.LOW, SeverityPriority.MEDIUM, SeverityPriority.HIGH });

                    string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                    bool checkInfo = ConvertToBool(correctInfo);
                    if (checkInfo)
                    {
                        ProblemService tempService = new ProblemService(description, severityPriority);
                        ProblemList.Add(tempService);
                    }
                    Menu(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                }
            }



            static void EditService(List<TimeLlog> TimelogList, List<Commercial> CommercialList, List<Domestic> DomesticList, List<Customer> CustomerList, List<CosmeticService> CosmeticList, List<ProblemService> ProblemList, List<Purchase> PurchaseList, List<TeamMember> TeamMemberList)
            {
                string[] services = { };

                var serviceType = Prompt.Select("Select service type", new[] { "Cosmetic", "Problem" });
                if (serviceType == "Cosmetic")
                {
                    foreach (CosmeticService i in CosmeticList)
                    {
                        services.ToArray();
                    }


                    CosmeticService editService = Prompt.Select("Select a service to edit", CosmeticList);
                    foreach (CosmeticService i in CosmeticList)
                    {
                        if (i == editService)
                        {
                            string description = Prompt.Input<string>("Enter the service description");


                            string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                            bool checkInfo = ConvertToBool(correctInfo);
                            if (checkInfo)
                            {
                                i.Description = description;
                            }
                            Menu(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                        }
                    }
                }
                else
                {
                    foreach (ProblemService i in ProblemList)
                    {
                        services.ToArray();
                    }


                    ProblemService editService = Prompt.Select("Select a service to edit", ProblemList);
                    foreach (ProblemService i in ProblemList)
                    {
                        if (i == editService)
                        {
                            string description = Prompt.Input<string>("Enter the service description");
                            SeverityPriority severityPriority = Prompt.Select<SeverityPriority>("Select the severity of the issue", new[] { SeverityPriority.LOW, SeverityPriority.MEDIUM, SeverityPriority.HIGH });


                            string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                            bool checkInfo = ConvertToBool(correctInfo);
                            if (checkInfo)
                            {
                                i.Description = description;
                                i.Severity = severityPriority;
                            }
                            Menu(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                        }
                    }
                }
            }



            static void AddStaff(List<TimeLlog> TimelogList, List<Commercial> CommercialList, List<Domestic> DomesticList, List<Customer> CustomerList, List<CosmeticService> CosmeticList, List<ProblemService> ProblemList, List<Purchase> PurchaseList, List<TeamMember> TeamMemberList)
            {
                string fname = Prompt.Input<string>("Enter your first name");
                string lname = Prompt.Input<string>("Enter your last name");
                string username = Prompt.Input<string>("Enter your username");
                string password = Prompt.Password("Enter your password");
                EmployeeType type = Prompt.Select<EmployeeType>("Select your role", new[] { EmployeeType.ADMIN, EmployeeType.MANAGER, EmployeeType.CLEANER, EmployeeType.MAINTENANCE, EmployeeType.TEAM_MEMBER });


                string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                bool checkInfo = ConvertToBool(correctInfo);
                if (checkInfo)
                {
                    TeamMember tempEmployee = new TeamMember(fname, lname, username, password, type);
                    TeamMemberList.Add(tempEmployee);

                    Menu(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                }
            }



            static void EditStaff(List<TimeLlog> TimelogList, List<Commercial> CommercialList, List<Domestic> DomesticList, List<Customer> CustomerList, List<CosmeticService> CosmeticList, List<ProblemService> ProblemList, List<Purchase> PurchaseList, List<TeamMember> TeamMemberList)
            {
                string[] teamMembers = { };

                foreach (TeamMember i in TeamMemberList)
                {
                    teamMembers.ToArray();
                }


                TeamMember editTeamMember = Prompt.Select("Select the team member to edit", TeamMemberList);
                foreach (TeamMember i in TeamMemberList)
                {
                    if (i == editTeamMember)
                    {
                        string fname = Prompt.Input<string>("Enter your first name");
                        string lname = Prompt.Input<string>("Enter your last name");
                        string username = Prompt.Input<string>("Enter your username");
                        string password = Prompt.Password("Enter your password");
                        EmployeeType type = Prompt.Select<EmployeeType>("Select your role", new[] { EmployeeType.ADMIN, EmployeeType.MANAGER, EmployeeType.CLEANER, EmployeeType.MAINTENANCE, EmployeeType.TEAM_MEMBER });


                        string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                        bool checkInfo = ConvertToBool(correctInfo);
                        if (checkInfo)
                        {
                            i.Fname = fname;
                            i.Lname = lname;
                            i.Username = username;
                            i.Password = password;
                            i.StaffType = type;
                        }
                        Menu(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                    }
                }
            }



            static void AddTimelog(List<TimeLlog> TimelogList, List<Commercial> CommercialList, List<Domestic> DomesticList, List<Customer> CustomerList, List<CosmeticService> CosmeticList, List<ProblemService> ProblemList, List<Purchase> PurchaseList, List<TeamMember> TeamMemberList)
            {
                int timeInMinutes = Prompt.Input<int>("Enter the amount of minutes");


                string[] employees = { };
                foreach (TeamMember i in TeamMemberList)
                {
                    employees.ToArray();
                }
                TeamMember teamMember = Prompt.Select("Select the member of staff", TeamMemberList);


                string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                bool checkInfo = ConvertToBool(correctInfo);
                if (checkInfo)
                {
                    TimeLlog tempTimelog = new TimeLlog(timeInMinutes, teamMember);
                    TimelogList.Add(tempTimelog);
                }
            }


            static void ViewTimelog(List<TimeLlog> TimelogList, List<Commercial> CommercialList, List<Domestic> DomesticList, List<Customer> CustomerList, List<CosmeticService> CosmeticList, List<ProblemService> ProblemList, List<Purchase> PurchaseList, List<TeamMember> TeamMemberList)
            {
                foreach (TimeLlog i in TimelogList)
                {
                    Console.WriteLine(i);
                }
                Menu(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
            }



            static void PurchaseMaterials(List<TimeLlog> TimelogList, List<Commercial> CommercialList, List<Domestic> DomesticList, List<Customer> CustomerList, List<CosmeticService> CosmeticList, List<ProblemService> ProblemList, List<Purchase> PurchaseList, List<TeamMember> TeamMemberList)
            {
                string description = Prompt.Input<string>("Enter the description of the products needed");
                double cost = Prompt.Input<double>("Purchase cost");


                string[] teamMembers = { };
                foreach (TeamMember i in TeamMemberList)
                {
                    teamMembers.ToArray();
                }
                TeamMember tempTeamMember = Prompt.Select("Select the team member to edit", TeamMemberList);


                string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                bool checkInfo = ConvertToBool(correctInfo);
                if (checkInfo)
                {
                    Purchase tempPurchase = new Purchase(description, cost, tempTeamMember);
                    PurchaseList.Add(tempPurchase);
                    Menu(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
                }
            }



            static void ViewPurchases(List<TimeLlog> TimelogList, List<Commercial> CommercialList, List<Domestic> DomesticList, List<Customer> CustomerList, List<CosmeticService> CosmeticList, List<ProblemService> ProblemList, List<Purchase> PurchaseList, List<TeamMember> TeamMemberList)
            {
                foreach (Purchase i in PurchaseList)
                {
                    Console.WriteLine(i);
                }
                Menu(TimelogList, CommercialList, DomesticList, CustomerList, CosmeticList, ProblemList, PurchaseList, TeamMemberList);
            }



            static void Quit()
            {
                Environment.Exit(0);
            }



            static bool ConvertToBool(string correctInfo)
            {
                switch (correctInfo)
                {
                    case ("Yes"):
                        return true;
                    default:
                        return false;
                }
            }
        }
    }
}
