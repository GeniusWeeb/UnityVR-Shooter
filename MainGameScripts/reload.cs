using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reload : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision other)
      {
          if (other.gameObject.CompareTag("clone"))
          {
            Debug.Log("Reload game");

            SceneManager.LoadSceneAsync("Level2Game");


          }
      }
}
