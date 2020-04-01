using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveP2 : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public Transform target = null;
    public Transform target2 = null;
    public GameObject C;
    public GameObject D;
    bool bJump = false;
    bool bJump2 = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Teleport2")
        {
            C.transform.position = target.position;
            D.transform.position = target2.position;

        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Teleport")
        {
        }

    }
}


