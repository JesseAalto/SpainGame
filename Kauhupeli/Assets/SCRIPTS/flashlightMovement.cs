using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlightMovement : MonoBehaviour
{
    public Animator flashlightAnim;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if(Input.GetKey(KeyCode.LeftShift))
            {
                flashlightAnim.ResetTrigger("walk");
                flashlightAnim.SetTrigger("sprint");
            }
            else
            {
                flashlightAnim.ResetTrigger("sprint");
                flashlightAnim.SetTrigger("walk");
            }
        }
    }
}
