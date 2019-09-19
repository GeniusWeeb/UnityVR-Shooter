using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTrigger : MonoBehaviour
{

public GameObject start;
public GameObject audioStop;
public GameObject timer ;
public GameObject ScoreCounter;

  public GameObject BalloonSpawn;
    // Start is called before the first frame update

    void OnCollisionEnter(Collision other)
      {
          if (other.gameObject.CompareTag("clone"))
          {
            Debug.Log("Start Game");

                FindObjectOfType<au1>().Play("Countdown");
          BalloonSpawn.SetActive(true);
          timer.SetActive(true);
          ScoreCounter.SetActive(true);
          audioStop.SetActive(false);

          start.SetActive(false);

          }
      }

      public void Start()
      {

         var limbs = GetComponent<MeshRenderer>();

      }


    }
