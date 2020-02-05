using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze1Visibility : MonoBehaviour
{
    int count;
    public GameObject Maze1;
    public GameObject Maze2;
    public bool maze1Active = true;
    public bool maze2Active = false;
    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer mr1 = Maze1.gameObject.GetComponent<MeshRenderer>();
        mr1.enabled = true;
        Collider cr1 = Maze1.gameObject.GetComponent<Collider>();
        cr1.enabled = true;

        MeshRenderer mr2 = Maze2.gameObject.GetComponent<MeshRenderer>();
        mr2.enabled = false;
        Collider cr2 = Maze2.gameObject.GetComponent<Collider>();
        cr2.enabled = false;

        maze1Active = true;
        maze2Active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
         count = count + 1;
         if (count >=4) count =0;
        if (Input.GetMouseButton(1) && count == 0)
        {
            if (maze1Active == true && maze2Active == false)
            {
                MeshRenderer mr1 = Maze1.gameObject.GetComponent<MeshRenderer>();
                mr1.enabled = false;
                Collider cr1 = Maze1.gameObject.GetComponent<Collider>();
                cr1.enabled = false;

                MeshRenderer mr2 = Maze2.gameObject.GetComponent<MeshRenderer>();
                mr2.enabled = true;
                Collider cr2 = Maze2.gameObject.GetComponent<Collider>();
                cr2.enabled = true;

                maze1Active = false;
                maze2Active = true;
            }
            else if (maze1Active == false && maze2Active == true)
            {
                MeshRenderer mr1 = Maze1.gameObject.GetComponent<MeshRenderer>();
                mr1.enabled = true;
                Collider cr1 = Maze1.gameObject.GetComponent<Collider>();
                cr1.enabled = true;

                MeshRenderer mr2 = Maze2.gameObject.GetComponent<MeshRenderer>();
                mr2.enabled = false;
                Collider cr2 = Maze2.gameObject.GetComponent<Collider>();
                cr2.enabled = false;

                maze1Active = true;
                maze2Active = false;
            }
        }
    }

  
}
