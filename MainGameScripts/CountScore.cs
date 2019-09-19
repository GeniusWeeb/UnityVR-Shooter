using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScore : MonoBehaviour
{       public TextMesh Score;


void Start()
      {
          Score  =  GetComponentInChildren<TextMesh>();




      }

    public int count= 0;
    // Start is called before the first frame update
  public void IncrementScore()
  {   Debug.Log("reached the score part bois");
      count ++;
      Score.text = count.ToString();


  }









}
