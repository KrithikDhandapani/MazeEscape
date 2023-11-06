using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    public float speed = 6f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    public float jump = 10;


    // Update is called once per frame
    void Update()
    {
         float horizontal = Input.GetAxisRaw("Horizontal");
         float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        
        
      

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
          // transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 movedir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(movedir.normalized * speed * Time.deltaTime);
        }
    }

    public void savePlayer()
    {
        SaveSystem.savePlayer(this);

    }
    public void loadPlayer()
    {
       PlayerData data =  SaveSystem.loadPlayer();

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
    }
}
