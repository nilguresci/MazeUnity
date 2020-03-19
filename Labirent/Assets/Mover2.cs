using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover2 : MonoBehaviour
{

    public GameObject Code;
    void Start()
    {

    }

    void Update()
    {
        float hiz = 20f;

        Vector3 konum = transform.position;
        if (Input.GetKey("h"))
        {
            konum.x -= hiz * Time.deltaTime;
        }
        if (Input.GetKey("k"))
        {
            konum.x += hiz * Time.deltaTime;
        }
        if (Input.GetKey("u"))
        {
            konum.z += hiz * Time.deltaTime;
        }
        if (Input.GetKey("j"))
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
