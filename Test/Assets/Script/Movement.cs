using System.Collections;
using System.Collections.Generic;
using UnityEditor.Playables;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    Player playerAttribute;
    public float additionSpeed=230;
    public float additionJump = 5;
    public float talentSpeed = 0;
    public bool isGrounded = false;
    public Transform feetPos;
    public float checkRadius =0.3f;
    public LayerMask groundType;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAttribute = GetComponent<Player>();
    }
    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, groundType);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
       if(Input.GetAxisRaw("Horizontal") != 0)
        MovementPlayer(playerAttribute.at.Agility);

       if (Input.GetAxisRaw("Vertical") > 0 && isGrounded)
            Jump(playerAttribute.at.Force);
    }

    public void MovementPlayer(float agility)
    {
        float movmentX = Input.GetAxisRaw("Horizontal") * ((agility+talentSpeed)*2.5f + additionSpeed)  * Time.fixedDeltaTime;

        rb.velocity = new Vector2(movmentX, rb.velocity.y);
        Debug.Log(movmentX);
    }
    public void Jump(float force)
    {
        float movmentY =(force*0.2f)+additionJump;

        rb.velocity = new Vector2(rb.velocity.x, movmentY);
        Debug.Log(movmentY);
    }

}
