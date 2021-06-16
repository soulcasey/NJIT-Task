using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickObject : MonoBehaviour
{
    public GameObject cube;
    private int score;
    public Text textScore;
    public Text timeScore;
    public Text timeFlow;
    private float timePass;
    private AudioSource clickSound;
    void Start()
    {
        RandomPosition();
        score = 0;
        timePass = Time.time ;
        clickSound = GetComponent<AudioSource>();
    }

   
    void FixedUpdate()
    {
        textScore.text = (score).ToString();

        timeFlow.text = ((Time.time - timePass)).ToString("0.00") + "s";

        cube.transform.Rotate(1, 0.5f, 1);
        if (Input.GetKey("up"))
        {
            cube.transform.localScale += new Vector3(0.02f, 0.02f, 0.02f);
        }

        if (Input.GetKey("down") && cube.transform.localScale.x > 0)
        {
            cube.transform.localScale -= new Vector3(0.02f, 0.02f, 0.02f);
        }

    }

    private void OnMouseDown()
    {
        clickSound.Play();
        timeScore.text = ((Time.time - timePass)).ToString("0.00") + "s";
        RandomPosition();
        score++;
    }

    void RandomPosition()
    {
        Vector3 position = new Vector3(Random.Range(8f, -8f), Random.Range(5f, -3f), 0);
        if (position.x < -6.5f && position.y > 4.5f)
        {
            position = new Vector3(Random.Range(8f, -8f), Random.Range(5f, -3f), 0);
        }
        cube.transform.position = position;
        timePass = Time.time;
    }
}
