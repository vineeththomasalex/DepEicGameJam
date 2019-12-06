using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheThang : MonoBehaviour
{
    private Vector3 movementDirection;
    private CharacterController charController;
    public float MovementSpeed;
    public float Gravity = -9.8f;
    // Start is called before the first frame update
    void Start()
    {   
        charController = this.GetComponent<CharacterController>();
        if(charController == null)
        {
            Debug.Log("No Char Controller on this obj:"+ this.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"));
        movementDirection = movementDirection.normalized * MovementSpeed;

        movementDirection.y = Gravity;
        charController.Move(movementDirection * Time.deltaTime);

    }
}
