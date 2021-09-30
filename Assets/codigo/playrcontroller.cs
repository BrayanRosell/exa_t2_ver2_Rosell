using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playrcontroller : MonoBehaviour
{
    private SpriteRenderer sr;
    private Animator animator;
    private Rigidbody2D rb2d;
    private float speed = 6;
    
    // Start is called before the first frame update
    void Start()
    {
        sr= GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     rb2d.gravityScale = 35;
         quieto();
        
        if(Input.GetKey(KeyCode.RightArrow))
        {
            sr.flipX = false;
            corre();
            
            rb2d.velocity = new Vector2(speed,rb2d.velocity.y);
            if(Input.GetKey(KeyCode.Space))
            {            
            saltarF();
            
            }
            if(Input.GetKey(KeyCode.X))
            {
            lanzar();
            }
             if(Input.GetKey(KeyCode.Z))
            {
            deslizar();
            }
          
        }else if(Input.GetKey(KeyCode.LeftArrow))
        {
            sr.flipX = true;
            corre();
            rb2d.velocity = new Vector2(-speed,rb2d.velocity.y);
            if(Input.GetKey(KeyCode.Space))
            {
               saltarF();
             
           
            }
            if(Input.GetKey(KeyCode.X))
            {
            lanzar();
           
            }
             if(Input.GetKey(KeyCode.Z))
            {
            deslizar();
            }
        }
        else
        {
            quieto();
            rb2d.velocity = new Vector2(0,rb2d.velocity.y);
            if(Input.GetKey(KeyCode.Space))
            {
            saltarF();
            }
            if(Input.GetKey(KeyCode.X))
            {
            lanzar();
           
            }
             if(Input.GetKey(KeyCode.Z))
            {
            deslizar();
            }
        }
    }
    public void saltarF(){
        var upSpeed = 80f;
        rb2d.velocity = Vector2.up * upSpeed;
        salta();
    }
    public void quieto(){
        animator.SetInteger("Estado", 0);        
    }
     public void corre(){
        animator.SetInteger("Estado", 1);        
    }
     public void salta(){
        animator.SetInteger("Estado", 2);        
    }
    public void muere(){
        animator.SetInteger("Estado", 3);        
    }
    public void deslizar(){
        animator.SetInteger("Estado", 4);        
    }
    public void trepar(){
        animator.SetInteger("Estado", 5);        
    }
    public void glide(){
        animator.SetInteger("Estado", 6);        
    }
    public void lanzar(){
        animator.SetInteger("Estado", 7);        
    }
}
