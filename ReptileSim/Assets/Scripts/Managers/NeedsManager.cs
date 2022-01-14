using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedsManager: MonoBehaviour
{

    public static float gameHourTimer;
    public float hourLength;
     
    
    // Start is called before the first frame update
    void Start()
    {
        
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
