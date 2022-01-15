using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedsManager: MonoBehaviour
{
    public float gameHourTimer;
    public float hourLength;
    
    public static NeedsManager instance;

     
    
    // Start is called before the first frame update
    void Start()
    {
         if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameHourTimer <=0)
        {
            gameHourTimer = hourLength;
        
        }
        else
        {
            gameHourTimer -= Time.deltaTime;
        }
    }
    

}
