using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerssonajeP : MonoBehaviour
{
    public float vel;
    bool isLeft = false;
    bool isRight = false;
    bool isUp = false;
    bool isDown = false;
    public Animator anim;
    private Rigidbody2D rb;
    public SpriteRenderer spr;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {

        if (isLeft)
        {
              
          
            rb.transform.Translate(translation: (Vector3)(new Vector2(x: -vel, y: 0) * Time.deltaTime));
        }

        if (isRight)
        {
            rb.transform.Translate(translation: (Vector3)(new Vector2(x: vel, y: 0) * Time.deltaTime));
        }

        if (isUp)
        {
            rb.transform.Translate(translation: (Vector3)(new Vector2(x:0, y: vel) * Time.deltaTime));
        }

        if (isDown)
        {
            rb.transform.Translate(translation: (Vector3)(new Vector2(x: 0, y: -vel) * Time.deltaTime));
        }
    }

    public void clickLeft()
    {
        isLeft = true;
        anim.SetTrigger("run");
        spr.flipX = true;
    }

    public void releaseLeft()
    {
        isLeft = false;
        anim.SetTrigger("ide");
       
    }

    public void clickRight()
    {
        isRight = true;
        anim.SetTrigger("run");
        spr.flipX = false;
    }

    public void releaseRight()
    {
        isRight = false;
        anim.SetTrigger("ide");
        

    }

    public void clickUp()
    {
        isUp = true;
        anim.SetTrigger("run");
       
    }

    public void releaseUp()
    {
        isUp = false;
        anim.SetTrigger("ide");
    }

    public void clickDown()
    {
        isDown = true;
        anim.SetTrigger("run");
    }

    public void releaseDown()
    {
     isDown = false;
        anim.SetTrigger("ide");
    }
}
