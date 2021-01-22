using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonD : MonoBehaviour
{
    int number = 0;
    bool sw;
    int wait = 0;


    [SerializeField]
    private Button btn;
    [SerializeField]
    private Button btnr;
    [SerializeField]
    private Button btnl;
    


    public void ButtonPushed()
	{
		Debug.Log("ボタンが押されました");
        sw = true;
        number = 1;

	}

    // Start is called before the first frame update
    void Start()
    {

        //switch文
    }

    // Update is called once per frame
    void Update()
    {

        switch(number){

            case 1:
                Debug.Log("処理１");
                wait ++;
                if(wait == 300){
                btnr.onClick.Invoke();
                number = 2;
                wait = 0;
                }
                break;

            case 2:
                Debug.Log("処理2");
                wait ++;
                if(wait == 300){
                btnr.onClick.Invoke();
                number = 3;
                wait = 0;
                }
                break;

            case 3:
                Debug.Log("処理3");
                wait ++;
                if(wait == 300){
                btnr.onClick.Invoke();
                number = 4;
                wait = 0;
                }
                break;

            case 4:
                Debug.Log("処理4");
                wait ++;
                if(wait == 300){
                btnl.onClick.Invoke();
                number = 5;
                wait = 0;
                }
                break;

            case 5:
                Debug.Log("処理5");
                wait ++;
                if(wait == 300){
                btnl.onClick.Invoke();
                number = 6;
                wait = 0;
                }

                break;

            case 6:
                Debug.Log("処理6");
                wait ++;
                if(wait == 300){
                btnl.onClick.Invoke();
                number = 7;
                wait = 0;
                }

                break;

            default:
                Debug.Log("Default");
                break;
        }

    }

}
