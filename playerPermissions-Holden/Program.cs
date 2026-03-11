//this is me stealing my own code for partial credit on this assignment, they look very much the same

using System;

class Program
{// use the "getting somewhere commit" for a clean compile of permission system menu working, its flawed but it runs.
    // add new menu head through if statement has kinda caused issues. need to figure out why they all run the same menu
    // line above in simple words: Changed all 3 methods to if number run just one.
    public static int action;
    public static int action2;
    public static string userInput = "bruh";
    public static Permissions userPermissions;     
    public static bool mainMenuBool = true;
    public static void Main()
    {
        // Permissions userPermissions = Permissions.None;
        //System.Console.WriteLine((int)userPermissions);


        ApplicationMenu();

        //userPermissions = Permissions.Read | Permissions.Write;

        //Console.WriteLine($"Current Permissions: {userPermissions} ");


        
    } //void main end
    

    [Flags]
    public enum Permissions{
        //when we use the singular or| operator it combines/add the 2 powers we have for our new Hero/employee
        None = 0, //1st option available is 0
        Read = 1, //2nd option available
        Write = 2, //3rd option available
        Delete = 4, //4th
        Execute = 8, //5th
        ViewReports = 16 //6th option available
    }

                //Permission Menu
    public static void ApplicationMenu()
    {
        //give permissions of none, read, write, delete, execute, or  viewreports
        while (mainMenuBool)
        {

            Console.WriteLine("==== Permission System ====");
            Console.WriteLine("1. Add Permission");
            Console.WriteLine("2. Show Current Permissions");
            Console.WriteLine("3. Perform Action");
            Console.WriteLine("4. Exit");

            action = int.Parse(Console.ReadLine());
            //action2 = int.Parse(Console.ReadLine());
                        //need to make this an if statement to run a choice isntead of all 3
             switch(action)
            {
                case 1:                  
                    AddPermissionMethod();
                    break;      
                case 2:                    
                    DisplayPermissionMethod();
                    break;
                case 3:                  
                    DisplayPermissionTextMethod();
                    break;      
                case 4:                    
                    System.Environment.Exit(0);
                    break;
                default:
                    ApplicationMenu();
                    break;
             } //closing menu bracket
            


            // 1. RunAddPermissionMethod
            
            // 2. Display permission
           // DisplayPermissionMethod();
            // 3. display text from permission
          //   DisplayPermissionTextMethod();
            // 4. break; - set mainMenuBool to false
            // permissionLevel = 


  
            /* userPermissions = Permissions.Read | Permissions.Write;

            Console.WriteLine($"Current Permissions: {userPermissions} "); */
        }    
    }
    public static void AddPermissionMethod()
    {
        Console.WriteLine("==== Permission Add ====");
            Console.WriteLine("1. None");
            Console.WriteLine("2. Read");
            Console.WriteLine("3. Write");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. Publish"); //different for the Canadian group
            Console.WriteLine("6. Admin"); //different for the canadian's in the room
            Console.WriteLine("7. Back");

            action2 = int.Parse(Console.ReadLine());

        switch(action2)
        {
            case 1:                    
                userPermissions |= Permissions.None;
                break;       
            case 2:                    
                userPermissions |= Permissions.Read;
                break;                
            case 3:                    
                userPermissions |= Permissions.Write;
                break;                
            case 4:                    
                userPermissions |= Permissions.Delete;
                break;                
            case 5:                   
                userPermissions |= Permissions.Execute;
                break;                
            case 6:                    
                userPermissions |= Permissions.ViewReports;
                break;
            case 7:                    
                ApplicationMenu();
                break;
            default:
                Console.WriteLine("Not quite sure what you said " +
                 "but it sounds like you want to add a permission");
                AddPermissionMethod();
                break;
        }

    }
    public static void DisplayPermissionMethod()
    {
        System.Console.WriteLine(userPermissions); //used to be userPermissions2 which 
                                                    //caused an error
    }
    public static void DisplayPermissionTextMethod()
    {
                //which permission text to see
        Permissions response = (Permissions)action;
        switch(response)
        {

            case Permissions.None:
                Console.WriteLine("User access denied");
                break;                
            case Permissions.Read:
                Console.WriteLine("User has Read access");
                break;                
            case Permissions.Write:
                Console.WriteLine("User has Write access");
                break;                
            case Permissions.Delete:
                Console.WriteLine("User has danger-zone access");
                break;                
            case Permissions.Execute:
                Console.WriteLine("User can run any program");
                break;                
            case Permissions.ViewReports:
                Console.WriteLine("This user is a super-user, can even view reports");
                break;

            //NOTES TO IMPLEMENT: dISPLAY WORKS GOOD, checked off, copy things off that
                // for feature building 
                //1 Need to make sure Users can type the String to select the permission they want
                //2 Need to add decision logic to display those different menu items
                    //lines 1 and 2 right there important, 2 might have to be implemented first
                    //Mr Jensen said you can use integers if you want, sounds harder though, 
                    //Our permissions uses int and string, its not that deep
                /*
                //NEED TO CHANGE THE HARDCODED 2 BACK TO USER INPUT FOR ANY PERMISSION SYSTEM SELECTION
                ==== Permission System ====
                    1. Add Permission
                    2. Show Current Permissions
                    3. Perform Action
                    4. Exit
                    2 """entered 2, its hardcoded at about line 96  System.Console.WriteLine(userPermissions2);"""
                    Read
                    User has Read access 
                                */
            //these might be the same but i swear they are on line 102 and line 71, look at the commit.
            //need to change the hardcoding on line 71
        }

    }
}
