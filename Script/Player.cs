using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  [SerializeField]  
  public Attribute at = new Attribute();

   
    // Start is called before the first frame update
    void Start()
    {
        //Inizializzazione degli attributi in base a una chiamata al server

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[System.Serializable]

public class Attribute {
    public int Healt;
    public int Energy;
    public float Agility;
    public int Force;
    public int Defense;
    

}




