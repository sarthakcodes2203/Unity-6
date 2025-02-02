using Unity.VisualScripting;
using UnityEngine;

public class demoCS : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    // Data Types: int, float, double, string, bool, char
    private string myName = "Sarthak";
    private int myAge = 20;
    private float myHeight = 5.9f;
    private bool isMale = true;

    // Operators: +, -, *, /, %, ++, --, +=, -=, *=, /=, ==, !=, >, <, >=, <=, &&, ||, !, ?:
    // Comparison Operators: ==, !=, >, <, >=, <=
    // Logical Operators: &&, ||, !
    // Ternary Operator: ?:

    public string[] names;
    public string[] names2 = new string[5];
    public string[] names3 = new string[] {"Sarthak", "Rahul", "Rohit", "Rajat", "Rohit"}; 

    public Camera mainCamera;
    void Start()
    {
        // Debug.Log("Hello World!");

        // Debug.Log("My Name is " + myName);


        // if(myAge > 18)
        // {
        //     Debug.Log("You are an Adult");
        // }
        // else if(myAge > 12)
        // {
        //     Debug.Log("You are a Teenager");
        // }
        // else
        // {
        //     Debug.Log("You are a Kid");
        // }

   
        // switch(myAge)
        // {
        //     case 18:
        //         Debug.Log("You are 18");
        //         break;
        //     case 20:
        //         Debug.Log("You are 20");
        //         break;
        //     default:
        //         Debug.Log("You are not 18 or 20");
        //         break;
        // }
        

        // for(int i = 0; i < 5; i++)
        // {
        //     Debug.Log("Hello World!");
        // }    

        // int i = 0;
        // while(i<5)
        // {
        //     Debug.Log("Hello World!");
        //     i++;
        // }

        // int i = 0;
        // do
        // {
        //     Debug.Log("Hello World!");
        //     i++;
        // }
        // while(i<5)

        // print5nums();
        // print5names("Sarthak", 20);
        // Debug.Log(sum(10, 20));


        // demoObj person = new demoObj();
        // person.name = "Sarthak";
        // person.age = 20;
        // person.height = 5.9f;
        // person.isMale = true;

        // person.walk();
        // person.run();

        // mainCamera.backgroundColor = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Sarthak Here! It gets repeated every frame");

    }

    private void print5nums()
    {
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }
    }
    
    private void print5names(string name,int age)
    {
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(name+" "+age+" repeat:"+i.ToString());
        }
    }
    private int sum(int a, int b)
    {
        int c= a+b;
        return c;
    }
    
}

public class demoObj

{
    public string name;
    public int age;
    public float height;
    public bool isMale;

    public void walk()
    {
        Debug.Log("Walking");
    }
    public void run()
    {
        Debug.Log("Walking");
    }
    
}


