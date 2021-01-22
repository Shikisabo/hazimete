﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            transform.Translate(-3,0,0);//左に3動かす
            //transform.Translate(-0.1f,0,0);
        }

        //右矢印が押されたとき
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            transform.Translate(3,0,0);//右に3動かす
        }
    }
    
    public void LButtonDown(){
        transform.Translate(-3,0,0);//左に3動かす
    }
    public void RButtonDown(){
        transform.Translate(3,0,0);//右に3動かす
    }

}