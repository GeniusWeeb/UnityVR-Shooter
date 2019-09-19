using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ttig : MonoBehaviour
{

    public int flag =1;
    public GameObject ActivateBalloon;


  [SerializeField]
   private  Animator plat;

    // Start is called before the first frame update
    void Start()

    {

    }


      void OnTriggerEnter(Collider other )
      {
          if(other.CompareTag("Player"))
          {
                    plat.SetBool("PlayerEnter",true);
                    ActivateBalloon.SetActive(true);



          }

      }

    // Update is called once per frame


}
