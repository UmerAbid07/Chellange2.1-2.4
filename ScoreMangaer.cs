using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMangaer : MonoBehaviour
{
    static float scoreIndex = 0;
    static float starIndex = 0;
    static bool score = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score == true)
        {
            scoreIndex++; 
            print("score" + scoreIndex);
            score = false;
            if (scoreIndex % 3 == 0)
            {
                starIndex++;
                print("STAR" + starIndex);
            }
        }
        

        
    }
    private void OnTriggerEnter(Collider other)
    {
        score = true;
       

    }
}
