using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemController : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float vel;
    // Start is called before the first frame update
    public float vel;
    void Start()
    {
        rb2d=this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
<<<<<<< HEAD
        if(rb2d.velocity.magnitude<5){
            rb2d.velocity += new Vector2(vel,0)*horizontalInput*Time.deltaTime;
        }
=======
        if(rb2d.velocity.magnitude < 5){
            rb2d.velocity +=  new Vector2(vel,0) * horizontalInput*Time.deltaTime;
        }
      

>>>>>>> e1db59a2c1ae6ec8d9e4e9a1700febe7e27fc35c
    }
}
