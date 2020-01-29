using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{

    public GameObject thecamera;
    public GameObject create;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // count = count + 1;
        // if (count >=4) count =0;
        // && count == 0 in that if statement right below
        // that slows the creation
        if(Input.GetMouseButton(1))
        {
            RaycastHit hit;
            Ray ray = thecamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                GameObject.Instantiate(create, hit.point, Quaternion.identity);
            }
        }
    }
}
