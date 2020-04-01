using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movep3 : MonoBehaviour
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
    public GameObject E;
    public GameObject F;
    bool bJump = false;
    bool bJump2 = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Teleport3")
        {
            E.transform.position = target.position;
            F.transform.position = target2.position;

        }


    }
}
