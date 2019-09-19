using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LetsHit: MonoBehaviour
{     public GameObject CollPrefab;//accessing a different script
GameObject explosion;
 CountScore NewScore;
    // Start is called before the first frame update
    void Start()
    {
NewScore = GameObject.FindWithTag("ScoreManager").GetComponent<CountScore>();
    }

    void OnCollisionEnter(Collision col){
       if (col.gameObject.tag == "Shootable")
       {
         explosion = Instantiate(CollPrefab,transform.position,transform.rotation) as GameObject;

       Destroy(explosion,1f);
       Destroy(col.gameObject);
          Debug.Log("asda");
                   FindObjectOfType<AuManager>().Play("Hit");
                   Debug.Log("sending shoot info");
                   NewScore.IncrementScore();

       }


       else if (col.gameObject.tag != "Shootable")
       {
         Debug.Log("we hit something else");
         explosion = Instantiate(CollPrefab,transform.position,transform.rotation) as GameObject;

       Destroy(explosion,1f);
       return;
}


     }


    // Update is called once per frame
    void Update()
    {

    }
}
