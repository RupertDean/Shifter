using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTransform : MonoBehaviour
{

    public BoxCollider2D boxCollider;
    public Animator anim;

    public BoxCollider2D cube;
    public PolygonCollider2D triangle;

    int state;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        state = anim.GetInteger("State");

        if(Input.GetKeyDown(KeyCode.E) && state < 1){
          state ++;
          anim.SetInteger("State", state);
        }

        if(Input.GetKeyDown(KeyCode.Q) && state > 0){
          state --;
          anim.SetInteger("State", state);
        }

        switch(state)
        {
          case(0):
            cube.enabled = true;
            triangle.enabled = false;
            break;
          case(1):
            cube.enabled = false;
            triangle.enabled = true;
            break;
        }

    }
}
