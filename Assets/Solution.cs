using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solution : MonoBehaviour
{
    System.Random randomGenerator = new System.Random();
   void Start()
  {
        //Uppgift_1A();
        //Uppgift_1C();
        //Uppgift_1B();
        //Uppgift_1D();
        //Uppgift_2A();
        //Uppgift_2B();
        //Uppgift_3A();
        //Uppgift_3B();
        //Uppgift_3C();
        //Uppgift_4A();
        //Uppgift_4B();
        //Uppgift_4C();
        //Uppgift_5A();
        //Uppgift_6A();
        Uppgift_7A();
        Uppgift_7C();
        // Uppgift ...
    }

  private void Uppgift_1A()
  {
    // lösning till uppgiften här
    Debug.Log("hej");
  } 
  private void Uppgift_1C()
  {
        double bredd = 5;
        double längd = 5;
        double area = bredd * längd;
        Debug.Log("Bredd: " + bredd + " Längd: " + längd + " Area: " + area);
  }
  private void Uppgift_1B()
  {
    double bredd = 10;
    double längd = 20;
    double area = (bredd * längd) / 2;
        Debug.Log("Rektangeln bredd: " + bredd + " Längd: " + längd + " Arean: " + area);
  }
  private void Uppgift_1D()
  {
        int tärningsnummer = randomGenerator.Next(1, 7);
        Debug.Log(tärningsnummer);
        if (tärningsnummer == 6)
        {
            Debug.Log("Grattis, du vann!!!");
        }

        else
        {
            Debug.Log("Du förlorade!");
        }
  }
  void Uppgift_2A()
  {
        int tärning = randomGenerator.Next(1, 6);
        Debug.Log(tärning);
        if (tärning == 1)
        {
            Debug.Log("Minsta talet!");
        }
        else
        {
            Debug.Log("Tal 2-6");
        }
  }

  void Uppgift_2B()
  {
        int tärning_1 = randomGenerator.Next(1,6);
        int tärning_2 = randomGenerator.Next(1,6);
        Debug.Log(tärning_1);
        Debug.Log(tärning_2);
        if (tärning_1 == tärning_2)
        {
            Debug.Log("Vinst!");
        }
        else
        {
            Debug.Log("Förlust!");
        }
  }

  void Uppgift_3A()
  {
        int tal = 1;
        while (tal <= 5)
        {
            Debug.Log(tal);
            tal++;
        }
  }
  void Uppgift_3B()
  {
        int tal = 5;
        while (tal <= 20)
        {
            Debug.Log(tal);
            tal = tal + 3;

        }
  }
  void Uppgift_3C()
  {
        int tal = 10;
        while (tal >= 0)
        {
            Debug.Log(tal);
            tal = tal - 1;
        }
  }
  void Uppgift_4A()
  {
        for (int tal = 1; tal <= 5; tal = tal + 1)
        {
            Debug.Log(tal);
        }
  }
  void Uppgift_4B()
  {
        for (int tal = 5; tal <= 20; tal = tal + 3)
        {
            Debug.Log(tal);
        }
  }
  void Uppgift_4C()
  {
        for (int tal = 10; tal >= 0; tal = tal - 1)
        {
            Debug.Log(tal);
        }
  }
  void Uppgift_5A()
  {
        int tärning = randomGenerator.Next(1, 6);
        while (tärning != 6)
        {
            Debug.Log(tärning);
            tärning = randomGenerator.Next(1, 6);
        }
        Debug.Log("Nu är du klar!");
  }
  void Uppgift_6A()
  {
        int tärning = randomGenerator.Next(1, 6);
        int tärning_2 = randomGenerator.Next(1, 6);
        int tärning_3 = tärning + tärning_2;
        Debug.Log(tärning);
        Debug.Log(tärning_2);

        if (tärning == tärning_2)
        {
            if(tärning_3 == 12)
            {
                Debug.Log("Storvinst!");
            }
        else
        {
                Debug.Log("Liten vinst!");
        }
        }
        else
        {
            Debug.Log("Förlust!");
        }     
  }
  void Uppgift_7A()
  {
        int[] lista = { 3, 5, 7, 9, 11, 13 };
        Debug.Log(lista[0]);
        Debug.Log(lista[1]);
        Debug.Log(lista[2]);
        Debug.Log(lista[3]);
        Debug.Log(lista[4]);
        Debug.Log(lista[5]);

        int[] tal = new int[5];

        string output = "";
        foreach (int talet in tal)
        {
            output += (talet + ", ");
        }
        Debug.Log(output);
    }
  void Uppgift_7C()
  {

  }

}