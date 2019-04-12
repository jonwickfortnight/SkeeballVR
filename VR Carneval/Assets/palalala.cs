using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palalala : MonoBehaviour
{
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        // Physics.IgnoreCollision(GameObject.Find("Pallo2").GetComponent<Collider>(), GetComponent<Collider>());
        startPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0f)
        {
            transform.position = startPosition;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }
    /*private void OnCollisionEnter(Collider collider)
    {
        if (collider.gameObject.tag == "reika")
        {
            transform.position = startPosition;
        }
    }
    */
    private void OnTriggerEnter(Collider other)
    {
        if(resetScript.peliKaynnissa)
        {
            if (other.gameObject.tag == "reika")
            {
                pisteetScript.skeeballPisteet++;
            }
            if (other.gameObject.tag == "reika2")
            {
                pisteetScript.skeeballPisteet += 3;
            }
            if (other.gameObject.tag == "reika3")
            {
                pisteetScript.skeeballPisteet += 5;
            }
            if (other.gameObject.tag == "reika4")
            {
                pisteetScript.skeeballPisteet += 10;
            }
        }
        if (other.gameObject.tag == "reika")
        {
            transform.position = startPosition;
        }
        if (other.gameObject.tag == "reika2")
        {
            transform.position = startPosition;
        }
        if (other.gameObject.tag == "reika3")
        {
            transform.position = startPosition;
        }
        if (other.gameObject.tag == "reika4")
        {
            transform.position = startPosition;
        }
    }
}