using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ChangeObject : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    public GameObject cylinder;
    public GameObject item;

    public VideoPlayer video;
    public VideoClip fire;
    public VideoClip water;
    public VideoClip grass;

    public AudioSource sound;
    public AudioClip fireSound;
    public AudioClip waterSound;
    public AudioClip grassSound;

    private Color itemColor;

    void Start()
    {
        if (DropDownMenu.scene == 0)
        {
            video.GetComponent<VideoPlayer>().clip = fire;
            sound.GetComponent<AudioSource>().clip = fireSound;
        }

        if (DropDownMenu.scene == 1)
        {
            video.GetComponent<VideoPlayer>().clip = water;
            sound.GetComponent<AudioSource>().clip = waterSound;
        }

        if (DropDownMenu.scene == 2)
        {
            video.GetComponent<VideoPlayer>().clip = grass;
            sound.GetComponent<AudioSource>().clip = grassSound;
        }

        if (DropDownMenu.color == 0)
        {
            itemColor = Color.red;
        }

        if (DropDownMenu.color == 1)
        {
            itemColor = Color.green;
        }

        if (DropDownMenu.color == 2)
        {
            itemColor = Color.cyan;
        }

        if (DropDownMenu.objecttype == 0)
        {
            cube.transform.localScale = new Vector3(1, 1, 1);
            cube.GetComponent<Renderer>().material.color = itemColor;
        }

        if (DropDownMenu.objecttype == 1)
        {
            sphere.transform.localScale = new Vector3(1, 1, 1);
            sphere.GetComponent<Renderer>().material.color = itemColor;
        }

        if (DropDownMenu.objecttype == 2)
        {
            cylinder.transform.localScale = new Vector3(1, 1, 1);
            cylinder.GetComponent<Renderer>().material.color = itemColor;
        }
        sound.Play();
    }

    void FixedUpdate()
    {
       

        if (Input.GetKey("up"))
        {
            item.transform.localScale += new Vector3(0.02f, 0.02f, 0.02f);
        }

        if (Input.GetKey("down") && item.transform.localScale.x > 0)
        {
            item.transform.localScale -= new Vector3(0.02f, 0.02f, 0.02f);
        }

        item.transform.Rotate(1, 0.5f, 1);
    }
}
