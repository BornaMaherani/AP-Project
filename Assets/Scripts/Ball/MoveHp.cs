using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform ball = GameObject.Find("Toop").GetComponent<Transform>();
        var pos = ball.position;
        TextMesh yourText = GameObject.Find("Toop").GetComponent<TextMesh>();
        yourText.transform.position = new Vector2(pos.x, pos.y);
    }

    // Update is called once per frame
    void Update()
    {
        Transform ball = GameObject.Find("Toop").GetComponent<Transform>();
        var pos = ball.position;
        TextMesh yourText = GameObject.Find("Toop").GetComponent<TextMesh>();
        yourText.transform.position = new Vector2(pos.x, pos.y);

    }
}
