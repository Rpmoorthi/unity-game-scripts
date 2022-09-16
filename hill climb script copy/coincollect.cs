using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class coincollect : MonoBehaviour
{
public TextMeshProUGUI textDisplay;
//    public Text MyscoreText;
   private int scorenum;
   public carcontroller carController;
   public int score=0;
   
   void Start () {
    scorenum=0;
    textDisplay.text = "Score:"+ scorenum;
   }


    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if(Coin.tag == "coin25")
        {
            Destroy(Coin.gameObject);
            scorenum +=5;
            Debug.Log("score: " + scorenum);
            textDisplay.text = "Score:"+ scorenum; 
        }
        if(Coin.tag == "coin100")
        {
            Destroy(Coin.gameObject);
            scorenum +=10;
            Debug.Log("score: " + scorenum);
            textDisplay.text = "Score:"+ scorenum; 
        }

        // Destroy(gameObject);
        // scorenum +=5;
        // Debug.Log("score: " + scorenum);
        // textDisplay.text = "Score:"+ scorenum;
    }
  
    // {
    //     // if(collision.tag =="coin25")
    //     // { // scorenum=0;
    //     // textDisplay.text = "Score:"+ scorenum;
    //     // // carController.fuel = 1;
    //     // scorenum ++;
    //     Destroy(gameObject);

    //     scorenum +=5;
    //     Debug.Log("score: " + scorenum);
    //     textDisplay.text = "Score:"+ scorenum;        
    //     // }
    // }
}
