using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonVOid : MonoBehaviour
{

    void OnTriggerEnter(Collider other )
    {
    if(other.gameObject.CompareTag("Shootable"))
        {
            StartCoroutine(destroy());
            Destroy(other);
        }

    }


    IEnumerator destroy()
    {
        yield return new WaitForSeconds(1f);




    }

    // Update is called once per frame
    void Update()
    {

    }
}
