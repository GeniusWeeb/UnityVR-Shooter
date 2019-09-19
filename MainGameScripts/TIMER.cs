using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TIMER : MonoBehaviour
{
    public GameObject GameOver;
    public float timer =  60f;
    public Text timerText ;
    public GameObject Balloon;

    public int condition = 0;
    public TextMesh time;
    // Start is called before the first frame update
    void Start()
    {

      //  timerText.text  =  timer.ToString();
       time =  GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {

            timer -= Time.deltaTime;
            time.text = Mathf.Round(timer).ToString();

            if (Mathf.Round(timer) < 0)
            {
                time.text = "TIME IS UP !!";
                Debug.Log("Game is over bois!!");

                Destroy(GameObject.FindWithTag("Finish"));


            }


    }



}
