using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System;

public class food : MonoBehaviour
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Pause = !Pause;
    }
    [SerializeField] GameObject child1, child2, child3;// child2.SetActive(true);
    [SerializeField] private TextMeshProUGUI uiText, uiText1;  //private Text uiText;

    public int Duration;
    double doubleVal=0;
    int outValue=0;

    private int remainingDuration;

    private bool Pause;

    private void Start()
    {
        // startTime = Time.time;
        Being(Duration);
        Debug.Log("Hello: " + uiText.text);
    }

    private void Being(int Second)
    {
        remainingDuration = Second;
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        while(remainingDuration >= 0)
        {
            if (!Pause)
            {
                // uiText.text = $"{remainingDuration /60}:{remainingDuration % 60}";
                // uiText.text = $"{remainingDuration / 60}";
                uiText.text = $"{remainingDuration % 60}";
                Debug.Log("Hello: " + uiText.text);
                remainingDuration--;

                bool isParsable = int.TryParse(uiText.text, out outValue);
                if(isParsable)
                  Debug.Log(isParsable);
                if(outValue<50)
                {
                    child1.SetActive(true);
                }
                if(outValue<40)
                {
                    child2.SetActive(true);
                }
                if(outValue<30)
                {
                    child3.SetActive(true);
                }
                yield return new WaitForSeconds(1f);
            }
            yield return null;
        }
        OnEnd();
    }

    private void OnEnd()
    {
        print("End");   
    }    
}
