using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rteload : MonoBehaviour
{
  public AudioSource reload;


    // Start is called before the first frame update
    void Start()
        {
              reload = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void play()
    {
        reload.Play();
          

    }
}
