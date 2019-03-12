 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        showMainMenu();

    }

    void showMainMenu() {
        Terminal.WriteLine("What would you like to hack into??.");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Enter your selection: ");
        Terminal.WriteLine("Great! ");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
