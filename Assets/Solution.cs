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
    Uppgift_1D();
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
}
