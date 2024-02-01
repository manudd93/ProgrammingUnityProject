using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    Player playerAttribute;
    public float additionSpeed=100;
    public float talentSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAttribute = GetComponent<Player>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       if(Input.GetAxisRaw("Horizontal") != 0)
        MovementPlayer(playerAttribute.at.Agility);
    }

    public void MovementPlayer(float agility)
    {
        float movmentX = Input.GetAxisRaw("Horizontal") * ((agility+talentSpeed)*1.5f + additionSpeed)  * Time.fixedDeltaTime;

        rb.velocity = new Vector2(movmentX, rb.velocity.y);
        Debug.Log(movmentX);
    }
       

}
