using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb2D = null;
    public float fallMultiplier;
    public float lowJumpMultiplier;

    private void Awake() {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            rb2D.AddForce(new Vector2(0,500));
        }

        if(Input.GetKey(KeyCode.A)){
            rb2D.AddForce(new Vector2(-10,0));
        }
        
        if(Input.GetKey(KeyCode.D)){
            rb2D.AddForce(new Vector2(10,0));
        }



        #region Gravity
        if (rb2D.velocity.y < 0)
        {
            rb2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier) * Time.deltaTime;
        }
        else if (rb2D.velocity.y > 0)
        {
            rb2D.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier) * Time.deltaTime;
        }
        #endregion
        
    }
}
