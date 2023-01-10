using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public int moveSpeed; //variable de mouvement
    public int rotationSpeed; //variable de rotation  
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed=5;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime, 0); //permet le déplacement avant et arriere 
        transform.Rotate(0, 0, -Input.GetAxis("Horizontal")*rotationSpeed*Time.deltaTime); //permet de tourner 

        if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed=20;
        }
        else
        {
            moveSpeed=5;
        }
    }
}
