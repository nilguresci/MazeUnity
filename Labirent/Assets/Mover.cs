using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{

    public GameObject Code;
    void Start()
    {
        
    }
    
    void Update()
    {
        float hiz = 20f;

        Vector3 konum = transform.position;
        if (Input.GetKey("a"))
        {
            konum.x -= hiz * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            konum.x += hiz * Time.deltaTime;
        }
        if (Input.GetKey("w"))
        {
            konum.z += hiz * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            konum.z -= hiz * Time.deltaTime;
        }
        transform.position = konum;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hedef")
        {
            Code.GetComponent<Panel>().Bitir();
        }
    }
}
