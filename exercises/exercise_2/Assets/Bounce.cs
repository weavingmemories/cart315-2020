using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public GameObject the_other_object;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == the_other_object)
        {
            Debug.Log("Testing");
            other.GetComponent<Rigidbody>().AddForce(0, 700.0f * Time.deltaTime, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == the_other_object)
        {
            other.GetComponent<AudioSource>().Play();
        }
        
    }
}
