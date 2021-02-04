using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float forwardForce = 2f;

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

        transform.position = position;
        controller.center = controller.center;

    }

    private void FixedUpdate()
    {
        controller.Move(direction * Time.fixedDeltaTime);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "Distractions") {
            PlayerManager.gameOver = true;
        }
    }

}
