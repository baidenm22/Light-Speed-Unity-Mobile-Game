using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlaneMovement : MonoBehaviour {

    public Transform P_Trans;
    public Transform P_Obj;
    public Animator P_Anim;
    public int ROLMovementSpeed;
    public int UODMovementSpeed;
   

    private float LeftOrRight;
    private float UpOrDown;
    private bool ChangeAnimation;
    private bool ChangeAnimation2;

    public int Movementspeed;
    public int UoDMovementspeed;


    // Update is called once per frame
    void Update () {


#if UNITY_STANDALONE || UNITY_WEBGL

        
        LeftOrRight = Input.GetAxisRaw("Horizontal");
        UpOrDown = Input.GetAxisRaw("Vertical");
        
        if (Input.GetButton("Horizontal"))
        {
            P_Trans.Translate(Vector2.right * LeftOrRight * ROLMovementSpeed * Time.deltaTime);
            P_Anim.SetBool("IsMoving", true);
            ChangeAnimation = false;
        } else
        {
            ChangeAnimation = true;
        }

        if (Input.GetButton("Vertical"))
        {
            P_Trans.Translate(Vector2.up * UpOrDown * UODMovementSpeed * Time.deltaTime);
            P_Anim.SetBool("IsMoving", true);
            ChangeAnimation2 = false;
        } else
        {
            ChangeAnimation2 = true;
        }

        

#else
        P_Trans.Translate(Vector2.right * Movementspeed * Time.deltaTime);
        P_Trans.Translate(Vector2.up * UoDMovementspeed * Time.deltaTime);
#endif

        if (ChangeAnimation && ChangeAnimation2)
        {
            P_Anim.SetBool("IsMoving", false);

        }
    }

    public void Up()
    {
        UoDMovementspeed = 5;
        P_Anim.SetBool("IsMoving", true);
        ChangeAnimation2 = false;
    }
    public void Down()
    {
        UoDMovementspeed = -5;
        P_Anim.SetBool("IsMoving", true);
        ChangeAnimation2 = false;
    }
    public void Right()
    {
        Movementspeed = 5;
        P_Anim.SetBool("IsMoving", true);
        ChangeAnimation = false;
    }
    public void Left()
    {
        Movementspeed = -5;
        P_Anim.SetBool("IsMoving", true);
        ChangeAnimation = false;
    }
   public  void UnpressUoD()
    {
        UoDMovementspeed = 0;
        ChangeAnimation2 = true;
    }
    public void UnpressROL()
    {
        Movementspeed = 0;
        ChangeAnimation = false;
    } 

}