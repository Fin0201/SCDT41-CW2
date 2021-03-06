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
            //Creates a new list for each of the classes used in the CLI.
            List<Timelog> timelogList = new List<Timelog>();
            List<Commercial> commercialList = new List<Commercial>();
            List<Domestic> domesticList = new List<Domestic>();
            List<CosmeticService> cosmeticList = new List<CosmeticService>();
            List<ProblemService> problemList = new List<ProblemService>();
            List<Purchase> purchaseList = new List<Purchase>();
            List<Customer> customerList = new List<Customer>();
            List<TeamMember> teamMemberList = new List<TeamMember>();



            Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList); //Calls the menu method
            static void Menu(List<Timelog> timelogList, List<Commercial> commercialList, List<Domestic> domesticList, List<Customer> customerList, List<CosmeticService> cosmeticList, List<ProblemService> problemList, List<Purchase> purchaseList, List<TeamMember> teamMemberList) //creates the menu method. Needs to include all of the list classes so the other methods will function when ran from the menu.
            {
                var menuSelection = Prompt.Select("Main Menu", new[] { "Add Property", "Edit Property", "Add Customer", "Edit Customer", "Add Service", "Edit Service", "Add Staff", "Edit Staff", "Purchase Materials", "View Purchases", "Add Timelog", "View Timelog", "Quit" }); //Asks the user to select one of the options.
                switch (menuSelection) //Checks to see what the user has picked.
                {
                    case ("Add Property"):
                        AddProperty(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                        break;
                    case ("Edit Property"):
                        EditProperty(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                        break;
                    case ("Add Customer"):
                        AddCustomer(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                        break;
                    case ("Edit Customer"):
                        EditCustomer(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                        break;
                    case ("Add Service"):
                        AddService(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                        break;
                    case ("Edit Service"):
                        EditService(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                        break;
                    case ("Add Staff"):
                        AddStaff(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                        break;
                    case ("Edit Staff"):
                        EditStaff(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                        break;
                    case ("Purchase Materials"):
                        PurchaseMaterials(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                        break;
                    case ("View Purchases"):
                        ViewPurchases(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                        break;
                    case ("Add Timelog"):
                        AddTimelog(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                        break;
                    case ("View Timelog"):
                        ViewTimelog(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                        break;
                    case ("Quit"):
                        Quit();
                        break;
                }
            }





            //Creates the AddProperty method.
            static void AddProperty(List<Timelog> timelogList, List<Commercial> commercialList, List<Domestic> domesticList, List<Customer> customerList, List<CosmeticService> cosmeticList, List<ProblemService> problemList, List<Purchase> purchaseList, List<TeamMember> teamMemberList)
            {
                if (customerList.Count == 0) //Checks to see if there are any customers being stored since they are needed for to add a property.
                {
                    string listEmpty = Prompt.Select("Error. This requires a customer", new[] { "Add a Customer", "Return to Menu" }); //Asks if the user would like to return to the menu or add a customer
                    switch (listEmpty)
                    {
                        case ("Add a Customer"):
                            AddCustomer(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                            break;
                        default:
                            Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                            break;
                    }
                }

                var propertyType = Prompt.Select("Select property type", new[] { "Commercial", "Domestic" });
                if (propertyType == "Commercial") //If the user selects commercial then they will be able to add a commercial property.
                {
                    //Asks the user to enter information about the commercial property.
                    string address = Prompt.Input<string>("Enter the property address");
                    string nameOfBusiness = Prompt.Input<string>("Enter the name of the business");
                    CommercialProperty type = Prompt.Select("Select the property type", new[] { CommercialProperty.OFFICE, CommercialProperty.HOTEL, CommercialProperty.WAREHOUSE, CommercialProperty.STORE });
                    double sizeInMeters = Prompt.Input<double>("Enter the property size in meters");
                    Customer owner = Prompt.Select("Select the customer", customerList);


                    string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" }); //Asks the user if the info they have entered is correct.
                    bool checkInfo = ConvertToBool(correctInfo); //Runs the ConvertToBool method to convert the answer into a bool.
                    if (checkInfo) //Checks if the bool is true.
                    {
                        Commercial tempCommercial = new Commercial(address, nameOfBusiness, type, sizeInMeters, owner);
                        commercialList.Add(tempCommercial); //Adds the info into commercialList.
                    }
                }
                else //If the user selected domestic property this will execute.
                {
                    //Asks the user to enter information about the property.
                    string address = Prompt.Input<string>("Enter the property address");
                    DomesticProperty type = Prompt.Select("Select the property type", new[] { DomesticProperty.DETACHED, DomesticProperty.SEMI_DETACHED, DomesticProperty.FLAT, DomesticProperty.BUNGALOW, DomesticProperty.COTTAGE });
                    int numberOfBedrooms = Prompt.Input<int>("Enter the number of bedrooms");
                    Customer owner = Prompt.Select("Select the customer", customerList);


                    string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" }); //Asks the user if the info they have entered is correct.
                    bool checkInfo = ConvertToBool(correctInfo); //Runs the ConvertToBool method to convert the answer into a bool.
                    if (checkInfo)
                    {
                        Domestic tempDomestic = new Domestic(address, type, numberOfBedrooms, owner);
                        domesticList.Add(tempDomestic); //Adds the info into domesticList.
                    }
                }
                Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList); //Returns to the menu.
            }

            


            //Creates the EditProperty method.
            static void EditProperty(List<Timelog> timelogList, List<Commercial> commercialList, List<Domestic> domesticList, List<Customer> customerList, List<CosmeticService> cosmeticList, List<ProblemService> problemList, List<Purchase> purchaseList, List<TeamMember> teamMemberList)
            {
                var propertyType = Prompt.Select("Select property type", new[] { "Commercial", "Domestic" });
                if (propertyType == "Commercial") //If the user selects commercial then they will be able to edit a commercial property.
                {
                    if (commercialList.Count == 0) //Checks if there are any commercial properties already stored.
                    {
                        string listEmpty = Prompt.Select("Error. This requires a commercial property", new[] { "Add a Property", "Return to Menu" }); //Asks if the user wants to add a proprty or return.
                        switch (listEmpty)
                        {
                            case ("Add a Property"):
                                AddProperty(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                                break;
                            default:
                                Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                                break;
                        }
                    }

                    Commercial editProperty = Prompt.Select("Select the property to edit", commercialList); //Asks the user to select the property to edit.
                    foreach (Commercial i in commercialList) //Selects the propery from commercialList
                    {
                        if (i == editProperty)
                        {
                            //Asks the user to re-enter the property information
                            string address = Prompt.Input<string>("Enter the property address");
                            string nameOfBusiness = Prompt.Input<string>("Enter the name of the business");
                            CommercialProperty type = Prompt.Select("Select the property type", new[] { CommercialProperty.OFFICE, CommercialProperty.HOTEL, CommercialProperty.WAREHOUSE, CommercialProperty.STORE });
                            double sizeInMeters = Prompt.Input<double>("Enter the property size in meters");
                            Customer owner = Prompt.Select("Select the customer", customerList);


                            string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" }); //Asks if these details are correct.
                            bool checkInfo = ConvertToBool(correctInfo); //Converts the answer to a bool.
                            if (checkInfo)
                            {
                                //Updates the infromation.
                                i.Address = address;
                                i.NameOfBusiness = nameOfBusiness;
                                i.PropertyType = type;
                                i.SizeInMeters = sizeInMeters;
                                i.CurrentOwner = owner;
                            }
                        }
                    }
                }
                else
                {
                    if (domesticList.Count == 0) //Checks if there are any domestic properties.
                    {
                        string listEmpty = Prompt.Select("Error. This requires a domestic property", new[] { "Add a Property", "Return to Menu" }); //Asks if the user wants to return to the menu or add a property.
                        switch (listEmpty)
                        {
                            case ("Add a Property"):
                                AddProperty(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                                break;
                            default:
                                Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                                break;
                        }
                    }

                    Domestic editProperty = Prompt.Select("Select the property to edit", domesticList); //Asks the user to select the property to edit.
                    foreach (Domestic i in domesticList) //Finds the selected doemstic property
                    {
                        if (i == editProperty)
                        {
                            //Asks the user to enter the new information
                            string address = Prompt.Input<string>("Enter the property address");
                            DomesticProperty type = Prompt.Select("Select the property type", new[] { DomesticProperty.DETACHED, DomesticProperty.SEMI_DETACHED, DomesticProperty.FLAT, DomesticProperty.BUNGALOW, DomesticProperty.COTTAGE });
                            int numberOfBedrooms = Prompt.Input<int>("Enter the number of bedrooms"); 
                            Customer owner = Prompt.Select("Select the customer", customerList);


                            //Checks if the information is valid
                            string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                            bool checkInfo = ConvertToBool(correctInfo);
                            if (checkInfo)
                            {
                                //Adds the new info
                                i.Address = address;
                                i.PropertyType = type;
                                i.NumberOfBedrooms = numberOfBedrooms;
                            }
                        }
                    }
                }
                Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
            }





            //Creates the AddCustomer method.
            static void AddCustomer(List<Timelog> timelogList, List<Commercial> commercialList, List<Domestic> domesticList, List<Customer> customerList, List<CosmeticService> cosmeticList, List<ProblemService> problemList,List<Purchase> purchaseList, List<TeamMember> teamMemberList)
            {
                //Asks the user to enter the information
                string fname = Prompt.Input<string>("Enter the customer's first name");
                string lname = Prompt.Input<string>("Enter the customer's last name");


                //Checks if the information is valid
                string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                bool checkInfo = ConvertToBool(correctInfo);
                if (checkInfo)
                {
                    //Adds the new info
                    Customer tempCustomer = new Customer(fname, lname);
                    customerList.Add(tempCustomer);
                }
                Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
            }





            //Creates the EditCustomer method.
            static void EditCustomer(List<Timelog> timelogList, List<Commercial> commercialList, List<Domestic> domesticList, List<Customer> customerList, List<CosmeticService> cosmeticList, List<ProblemService> problemList, List<Purchase> purchaseList, List<TeamMember> teamMemberList)
            {
                if (customerList.Count == 0)
                {
                    string listEmpty = Prompt.Select("Error. This requires a customer", new[] { "Add a Customer", "Return to Menu" });
                    switch (listEmpty) //makes sure there is aat least one customer
                    {
                        case ("Add a Customer"):
                            AddCustomer(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                            break;
                        default:
                            Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                            break;
                    }
                }

                Customer editCustomer = Prompt.Select("Select the customer to edit", customerList); //Asks the user to select a customer
                foreach (Customer customer in customerList)
                {
                    if (customer == editCustomer) //Finds the customer
                    {
                        string fname = Prompt.Input<string>("Enter the customer's first name");
                        string lname = Prompt.Input<string>("Enter the customer's last name");


                        //Checks if the information is valid
                        string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                        bool checkInfo = ConvertToBool(correctInfo);
                        if (checkInfo)
                        {
                            //Adds the new info
                            customer.Fname = fname;
                            customer.Lname = lname;
                        }
                    }
                }
                Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
            }





            //Creates the AddService method
            static void AddService(List<Timelog> timelogList, List<Commercial> commercialList, List<Domestic> domesticList, List<Customer> customerList, List<CosmeticService> cosmeticList, List<ProblemService> problemList, List<Purchase> purchaseList, List<TeamMember> teamMemberList)
            {
                var serviceType = Prompt.Select("Select service type", new[] { "Cosmetic", "Problem" });
                if (serviceType == "Cosmetic")
                {
                    //Asks the user to enter the info
                    string description = Prompt.Input<string>("Enter the service descripton");
                    string serviceState = Prompt.Select("Enter the service state", new[] { "Open", "Closed" });
                    bool isOpen = ConvertToBool(serviceState);


                    //Checks if the information is valid
                    string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                    bool checkInfo = ConvertToBool(correctInfo);
                    if (checkInfo)
                    {
                        //Adds the new info
                        CosmeticService tempService = new CosmeticService(description, isOpen);
                        cosmeticList.Add(tempService);
                    }
                }
                else
                {
                    //Asks the user to enter the info
                    string description = Prompt.Input<string>("Enter the service descripton");
                    SeverityPriority severityPriority = Prompt.Select("Select the severity of the issue", new[] { SeverityPriority.LOW, SeverityPriority.MEDIUM, SeverityPriority.HIGH });
                    string serviceState = Prompt.Select("Enter the service state", new[] { "Open", "Closed" });
                    bool isOpen = ConvertToBool(serviceState);


                    //Checks if the information is valid
                    string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                    bool checkInfo = ConvertToBool(correctInfo);
                    if (checkInfo)
                    {
                        //Adds the new info
                        ProblemService tempService = new ProblemService(description, severityPriority, isOpen);
                        problemList.Add(tempService);
                    }
                }
                Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
            }





            //Creates the EditService method
            static void EditService(List<Timelog> timelogList, List<Commercial> commercialList, List<Domestic> domesticList, List<Customer> customerList, List<CosmeticService> cosmeticList, List<ProblemService> problemList, List<Purchase> purchaseList, List<TeamMember> teamMemberList)
            {
                var serviceType = Prompt.Select("Select service type", new[] { "Cosmetic", "Problem" }); //Asks the user to select the service type
                if (serviceType == "Cosmetic")
                {
                    if (cosmeticList.Count == 0) //Makes sure there is at least one cosmetic service
                    {
                        string listEmpty = Prompt.Select("Error. This requires a cosmetic service", new[] { "Add a Service", "Return to Menu" });
                        switch (listEmpty)
                        {
                            case ("Add a Service"):
                                AddService(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                                break;
                            default:
                                Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                                break;
                        }
                    }

                    CosmeticService editService = Prompt.Select("Select a service to edit", cosmeticList); //Asks the user to select a service
                    foreach (CosmeticService i in cosmeticList)
                    {
                        if (i == editService) //Finds the selected service
                        {
                            string description = Prompt.Input<string>("Enter the service description");
                            string serviceState = Prompt.Select("Enter the service state", new[] { "Open", "Closed" });
                            bool isOpen = ConvertToBool(serviceState);


                            //Checks if the information is valid
                            string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                            bool checkInfo = ConvertToBool(correctInfo);
                            if (checkInfo)
                            {
                                //Adds the new info
                                i.Description = description;
                                i.IsOpen = isOpen;
                            }
                        }
                    }
                }
                else
                {
                    if (problemList.Count == 0) //Checks if there is at least one problem servie
                    {
                        string listEmpty = Prompt.Select("Error. This requires a problem service", new[] { "Add a Service", "Return to Menu" });
                        switch (listEmpty)
                        {
                            case ("Add a Service"):
                                AddService(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                                break;
                            default:
                                Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                                break;
                        }
                    }

                    ProblemService editService = Prompt.Select("Select a service to edit", problemList); //Asks the user to select a serivce
                    foreach (ProblemService i in problemList)
                    {
                        if (i == editService) //Finds the selected service
                        {
                            string description = Prompt.Input<string>("Enter the service description");
                            SeverityPriority severityPriority = Prompt.Select("Select the severity of the issue", new[] { SeverityPriority.LOW, SeverityPriority.MEDIUM, SeverityPriority.HIGH });
                            string serviceState = Prompt.Select("Enter the service state", new[] { "Open", "Closed" });
                            bool isOpen = ConvertToBool(serviceState);


                            //Checks if the information is valid
                            string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                            bool checkInfo = ConvertToBool(correctInfo);
                            if (checkInfo)
                            {
                                //Adds the new info
                                i.Description = description;
                                i.Severity = severityPriority;
                                i.IsOpen = isOpen;
                            }
                        }
                    }
                }
                Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
            }





            //Creates the AddStaff method
            static void AddStaff(List<Timelog> timelogList, List<Commercial> commercialList, List<Domestic> domesticList, List<Customer> customerList, List<CosmeticService> cosmeticList, List<ProblemService> problemList, List<Purchase> purchaseList, List<TeamMember> teamMemberList)
            {
                //Asks the user to input the info
                string fname = Prompt.Input<string>("Enter your first name");
                string lname = Prompt.Input<string>("Enter your last name");
                string username = Prompt.Input<string>("Enter your username");
                string password = Prompt.Password("Enter your password");
                EmployeeType type = Prompt.Select("Select your role", new[] { EmployeeType.ADMIN, EmployeeType.MANAGER, EmployeeType.CLEANER, EmployeeType.MAINTENANCE, EmployeeType.TEAM_MEMBER });


                //Checks if the information is valid
                string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                bool checkInfo = ConvertToBool(correctInfo);
                if (checkInfo)
                {
                    //Adds the new info
                    TeamMember tempEmployee = new TeamMember(fname, lname, username, password, type);
                    teamMemberList.Add(tempEmployee);
                }
                Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
            }





            //Creates the EditStaff method
            static void EditStaff(List<Timelog> timelogList, List<Commercial> commercialList, List<Domestic> domesticList, List<Customer> customerList, List<CosmeticService> cosmeticList, List<ProblemService> problemList, List<Purchase> purchaseList, List<TeamMember> teamMemberList)
            {
                if (teamMemberList.Count == 0) //CHecks that there is at least one team member
                {
                    string listEmpty = Prompt.Select("Error. This requires a team member", new[] { "Add a Team Member", "Return to Menu" });
                    switch (listEmpty)
                    {
                        case ("Add a Team Member"):
                            AddStaff(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                            break;
                        default:
                            Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                            break;
                    }
                }

                TeamMember editTeamMember = Prompt.Select("Select the team member to edit", teamMemberList); //Asks the user to select a team member
                foreach (TeamMember i in teamMemberList)
                {
                    if (i == editTeamMember) //Finds the team member
                    {
                        string fname = Prompt.Input<string>("Enter your first name");
                        string lname = Prompt.Input<string>("Enter your last name");
                        string username = Prompt.Input<string>("Enter your username");
                        string password = Prompt.Password("Enter your password");
                        EmployeeType type = Prompt.Select("Select your role", new[] { EmployeeType.ADMIN, EmployeeType.MANAGER, EmployeeType.CLEANER, EmployeeType.MAINTENANCE, EmployeeType.TEAM_MEMBER });


                        //Checks if the information is valid
                        string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                        bool checkInfo = ConvertToBool(correctInfo);
                        if (checkInfo)
                        {
                            //Adds the new info
                            i.Fname = fname;
                            i.Lname = lname;
                            i.Username = username;
                            i.Password = password;
                            i.StaffType = type;
                        }
                    }
                }
                Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
            }





            //Creates the PurchaseMaterials method
            static void PurchaseMaterials(List<Timelog> timelogList, List<Commercial> commercialList, List<Domestic> domesticList, List<Customer> customerList, List<CosmeticService> cosmeticList, List<ProblemService> problemList, List<Purchase> purchaseList, List<TeamMember> teamMemberList)
            {
                if (teamMemberList.Count == 0) //Checks there is at least one team member
                {
                    string listEmpty = Prompt.Select("Error. This requires a team member", new[] { "Add a Team Member", "Return to Menu" });
                    switch (listEmpty)
                    {
                        case ("Add a Team Member"):
                            AddStaff(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                            break;
                        default:
                            Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                            break;
                    }
                }

                //Asks the user to input the info
                string description = Prompt.Input<string>("Enter the description of the products needed");
                double cost = Prompt.Input<double>("Purchase cost");
                TeamMember tempTeamMember = Prompt.Select("Select the team member to edit", teamMemberList);


                //Checks if the information is valid
                string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                bool checkInfo = ConvertToBool(correctInfo);
                if (checkInfo)
                {
                    Purchase tempPurchase = new Purchase(description, cost, tempTeamMember); //Adds the new info
                    purchaseList.Add(tempPurchase); 
                }
                Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
            }




            //Creates the ViewPurchases method
            static void ViewPurchases(List<Timelog> timelogList, List<Commercial> commercialList, List<Domestic> domesticList, List<Customer> customerList, List<CosmeticService> cosmeticList, List<ProblemService> problemList, List<Purchase> purchaseList, List<TeamMember> teamMemberList)
            {
                foreach (Purchase i in purchaseList) //Loops through every item in the list
                {
                    Console.WriteLine(i); //Outputs the item
                }
                Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
            }




            //Creates the AddTimelog mehtod
            static void AddTimelog(List<Timelog> timelogList, List<Commercial> commercialList, List<Domestic> domesticList, List<Customer> customerList, List<CosmeticService> cosmeticList, List<ProblemService> problemList, List<Purchase> purchaseList, List<TeamMember> teamMemberList)
            {
                if (teamMemberList.Count == 0)
                {
                    string listEmpty = Prompt.Select("Error. This requires a team member", new[] { "Add a Team Member", "Return to Menu" });
                    switch (listEmpty)
                    {
                        case ("Add a Team Member"):
                            AddStaff(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                            break;
                        default:
                            Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
                            break;
                    }
                }
                int timeInMinutes = Prompt.Input<int>("Enter the amount of minutes");
                TeamMember teamMember = Prompt.Select("Select the member of staff", teamMemberList);


                //Checks if the information is valid
                string correctInfo = Prompt.Select("Are you sure these details are correct", new[] { "Yes", "No" });
                bool checkInfo = ConvertToBool(correctInfo);
                if (checkInfo)
                {
                    Timelog tempTimelog = new Timelog(timeInMinutes, teamMember); //Adds the new info
                    timelogList.Add(tempTimelog);
                }
                Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
            }





            //Creates the ViewTimeLog Method
            static void ViewTimelog(List<Timelog> timelogList, List<Commercial> commercialList, List<Domestic> domesticList, List<Customer> customerList, List<CosmeticService> cosmeticList, List<ProblemService> problemList, List<Purchase> purchaseList, List<TeamMember> teamMemberList)
            {
                foreach (Timelog i in timelogList) //Loops through every item in the list
                {
                    Console.WriteLine(i); //Outputs the item
                }
                Menu(timelogList, commercialList, domesticList, customerList, cosmeticList, problemList, purchaseList, teamMemberList);
            }





            //Creates the quit method
            static void Quit()
            {
                Environment.Exit(0); //Exits the console
            }





            //Creates the ConvertToBool method
            static bool ConvertToBool(string boolConvert)
            {
                if (boolConvert == "Yes" || boolConvert == "Open") //Checks if the value is the same as these words
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
