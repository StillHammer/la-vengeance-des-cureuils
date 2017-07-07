using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ici on utilise une bibliothèque (library) pour les éléments d'interface
using UnityEngine.UI; 

public class MainMenuScript : MonoBehaviour
{

    public int test;
    public int test2 = 5;
    private int test3;
    public GameObject buttontest;

       // Use this for initialization
    void Start()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
      
    }

    int Blabla (GameObject i)
    {
        return 1;
    }

    public void click(Button b)
    {
        Debug.Log("test");
            
    }
}
