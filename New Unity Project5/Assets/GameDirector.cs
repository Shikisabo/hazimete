using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject hpGauge;
    
    void Start()
    {
        this.hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecreaseHp(){
        this.hpGauge.GetComponent<Image> ().fillAmount -= 0.1f;
    }
}

