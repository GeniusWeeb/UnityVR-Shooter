using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class balloonSpawner : MonoBehaviour
{

    public int bFLag;

    public int xPos;
    public int ZPos;
    public GameObject Ballprefab;
    public int BallCount;
    GameObject new1;
    // Start is called before the first frame update
    void Start()
    {



            InvokeRepeating("spawn", 2f, 1f);



    }




    public void spawn()
    {
        if (BallCount < 100)
        {
            xPos = Random.Range(2000, -1500);
            ZPos = Random.Range(583,2170);

            new1 = Instantiate(Ballprefab, new Vector3(xPos, 1000, ZPos), Quaternion.identity) as GameObject;

            BallCount += 1;
            Destroy(new1,0.8f); // destroying all the object after 1.5 seconds after they spawned  basically we might even use a timer


        }



    }







    // Update is called once per frame

}
