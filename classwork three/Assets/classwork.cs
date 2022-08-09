using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classwork : MonoBehaviour
{
    string heroName = "micle jacson";
    int heroPower = 45;
    string villainName = "keto";
    int villainPower = 60;
    float playerspeed = 5.2f;
    // Start is called before the first frame update
    void Start()
    {
        print(playerspeed);
        setSpeed(2.5f);
        print(playerspeed);
        if (villainPower > heroPower)
        {
           print("keto is stronger");
        }
        else if (heroPower > villainPower)
        {
            print("micle jacson is stronger");
        }
        else
        {
            print("they have the same power");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void setSpeed(float newspeed)
    {
        print("the old speed is " + playerspeed);
        
        playerspeed = newspeed;
        print("the new speed is " + playerspeed);

    }
}