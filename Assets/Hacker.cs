 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    enum Screen { Mainmenu , Password , win };
    int level = 0 ;
    string password;
    Screen currentScreen = Screen.Mainmenu;


    // Start is called before the first frame update
    void Start()
    {
        
        showMainMenu();

    }

    void showMainMenu() {
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into??.");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Enter your selection: ");
        currentScreen = Screen.Mainmenu;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnUserInput(string input)
    {

        if (input == "menu")
        {
            showMainMenu();
        }
        else if (currentScreen.Equals(Screen.Mainmenu))
        {
            runMainMenu(input);
        }
        else if (currentScreen.Equals(Screen.Password))
        {
            runPassword(input);
        }
        else {
            showMainMenu();
        }
    



    }

    void runMainMenu(string input) {
        currentScreen = Screen.Mainmenu;

        if (input == "1" || input == "2")
        {

            level = int.Parse(input);
            startGame();

        }
        else
        {
            Terminal.WriteLine("Write 'menu','1' or '2' to select.");
        }

    }

    void startGame()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You have selected LEVEL:" + level);
        currentScreen = Screen.Password;
        if (level == 1)
        {
            Terminal.WriteLine("Welcome to the local library");

        }
        else
        {
            Terminal.WriteLine("Welcome to the Police Station.");

        }

        Terminal.WriteLine("Enter your Password: ");


    }

    void runPassword(string input) {
        password = input;
        if (string.Equals(password, "Harsh") || string.Equals(password, "Harsh Patel"))
        {
            Terminal.WriteLine("Congratulation You have entered the correct password. ");
            currentScreen = Screen.win;
            Terminal.WriteLine("Press any key then enter to play again.");

        }
        else {
            Terminal.WriteLine("Please enter the right password. ");
        
        }


    }



}
