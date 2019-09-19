using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReload : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("clone"))
        {

            //changes the scene
            SceneManager.LoadSceneAsync("MainShooter");


        }


    }

}
