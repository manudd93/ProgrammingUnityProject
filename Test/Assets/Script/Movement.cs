using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    Rigidbody2D RB;
    Player playerAttribute;
    public float VelocityPercentage=1000;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        playerAttribute = GetComponent<Player>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       //if(Input.GetAxisRaw("Horizontal"))
        MovementPlayer(playerAttribute.at.Agility);
    }

    public void MovementPlayer(float agility)
    {
        float movmentX = Input.GetAxisRaw("Horizontal") * (agility*0.1F) + VelocityPercentage  * Time.fixedDeltaTime;

        RB.velocity = new Vector2(movmentX, RB.velocity.y);
        Debug.Log(movmentX);
    }
       

}
