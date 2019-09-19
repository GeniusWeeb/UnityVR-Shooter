using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ontri : MonoBehaviour
{
    public GameObject gun;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
      if(other.tag == "GameController")
        gun.SetActive(true);


    }




}
