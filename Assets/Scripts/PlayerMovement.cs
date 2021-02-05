using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float forwardForce = 2;
    public float maxForwardForce = 10;

    private CharacterController controller;
    private Vector3 direction;
    private int lane =  1; // 0:left, 1:center, 2:right
    private float laneDistance = 3f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();        
    }

    // Update is called once per frame
    void Update()
    {

        if (forwardForce < maxForwardForce) {
            forwardForce += 0.1f * Time.deltaTime;
        }

        direction.z = forwardForce;
        if (Input.GetKeyDown("d"))
        {
            lane++;
            if (lane == 3) {
                lane = 2;
            }
        }
        else if (Input.GetKeyDown("a"))
        {
            lane--;
            if (lane == -1)
            {
                lane = 0;
            }
        }


        // calculate the next lane position

        Vector3 position = transform.position.z * transform.forward + transform.position.y * transform.up;

        if (lane == 0) {
            position += Vector3.left * laneDistance;
        } else if (lane == 2) {
            position += Vector3.right * laneDistance;
        }

        //transform.position = position;
        if (transform.position == position)
        {
            return;
        }
        else {
            Vector3 difference = position - transform.position;
            Vector3 movingDirection = difference.normalized * 100 * Time.deltaTime;
            if (movingDirection.sqrMagnitude < difference.sqrMagnitude)
            {
                controller.Move(movingDirection);
            }
            else {
                controller.Move(difference);    
            }
        }
        //controller.center = controller.center;

    }

    private void FixedUpdate()
    {
        controller.Move(direction * Time.fixedDeltaTime);
    }


}
