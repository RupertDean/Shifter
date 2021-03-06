using System.Collections.Generic;
using UnityEngine;

public class PlayerTransform : MonoBehaviour
{
    public Animator anim;

    public BoxCollider2D cube;
    public PolygonCollider2D triangle;
    public CircleCollider2D circle;

    int state = 1;

    // Start is called before the first frame update
    void Start()
    {
      anim.SetInteger("State", state);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && state < 2){
          state ++;
          anim.SetInteger("State", state);
        }

        if(Input.GetKeyDown(KeyCode.Q) && state > 0){
          state --;
          anim.SetInteger("State", state);
        }

        if(Input.GetKey(KeyCode.K)){
          anim.SetInteger("Colour", 0);
        }
        else if(Input.GetKey(KeyCode.L)){
          anim.SetInteger("Colour", 2);
        }
        else{
          anim.SetInteger("Colour", 1);
        }



        switch(state)
        {
          case(0):
            cube.enabled = false;
            triangle.enabled = true;
            break;
          case(1):
            cube.enabled = true;
            circle.enabled = false;
            triangle.enabled = false;
            break;
          case(2):
            circle.enabled = true;
            cube.enabled = false;
            break;
        }

    }
}
