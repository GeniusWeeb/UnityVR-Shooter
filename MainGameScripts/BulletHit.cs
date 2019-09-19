using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletHit : MonoBehaviour
{
  public GameObject explosionPrefab;
  public Text score;



  void Start()
  {




     //NewScore = GameObject.FindWithTag("ScoreManager").GetComponent<CountScore>();
     //extacting the script by defining a tag on the gameobject and hence recognising it.
  }


    // Start is called before the first frame update


    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("clone"))
        {
          FindObjectOfType<AuManager>().Play("Hit");


        //Debug.Log("sending shoot info");
          //NewScore.IncrementScore();

              //creates an explsion as whent he object is destroyed by the bullet
            Destroy(this.gameObject);
          //  handles score  generation


           // getting score from the shot objects


          }





    }




    // Update is called once per frame

}
