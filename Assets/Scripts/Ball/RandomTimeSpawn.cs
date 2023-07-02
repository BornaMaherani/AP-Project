using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class RandomTimeSpawn : MonoBehaviour
{
    public GameObject ball;
    private float targetTime;
    public static int count = 1;

    // Start is called before the first frame update
    void Start()
    {
        targetTime = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (count == 0)
        {
            targetTime = 0.5f; 
            targetTime -= Time.deltaTime;
            if(targetTime <= 0)
            {
                var newBall = Instantiate(ball, new Vector2(6, 6), Quaternion.identity);
                newBall.name = "newBall";
                count++;
                targetTime = Random.Range(4, 6);
            }
        }

        targetTime -= Time.deltaTime;
        if ((targetTime <= 0) && (count <= 4))
        {
            var newBall = Instantiate(ball, new Vector2(6, 6), Quaternion.identity);
            newBall.name = "newBall";
            targetTime = Random.Range(6,12);
            count++;
        }
        
    }
}
