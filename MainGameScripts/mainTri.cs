using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainTri : MonoBehaviour
{
    // Start is called before the first frame update


    void OnTriggerEnter(Collider other)
      {
          if (other.gameObject.CompareTag("Player"))
          {
              SceneManager.LoadSceneAsync("Level2Game");
          }
      }
    // Update is called once per frame

}
