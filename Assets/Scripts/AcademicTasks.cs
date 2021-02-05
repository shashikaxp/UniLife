using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcademicTasks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<AudioManager>().PlaySound("AcademicTask");
            if (PlayerManager.academicLife < 10) {
                PlayerManager.academicLife += 1;
            }           
            Destroy(gameObject);
        }
    }
}
