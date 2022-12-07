using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public float speed = 8f; 
    public GameObject player;
    public GameObject normalBullet;
    public GameObject normalBulletClone;

    private float delay = 0;
    public float bulletCooldown = 100;

    public int health;
    public int numberOfPepo;

    public Image[] pepos;
    public Sprite yesPepo;

    void Start()
    { 

    }

    void Update()
    {
        // if(health > numberOfPepo)
        // {
        //     health = numberOfPepo;
        // }

        for (int i = 0; i < pepos.Length; i++)
        {
            if (i < numberOfPepo)
            {
                pepos[i].enabled = true;
            } 
            else
            {
                pepos[i].enabled = false;
            }
        }
        movement();
        normalFire();
    }

    void movement() 
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 pos = transform.position;

        pos.x += h * speed * Time.deltaTime;
        pos.y += v * speed * Time.deltaTime;

        transform.position = pos;
    }

    void normalFire()
    {
        if (Input.GetKey(KeyCode.Space) && delay > bulletCooldown)
        {
            normalBulletClone = Instantiate(normalBullet, new Vector3(player.transform.position.x,player.transform.position.y + 1f,0), transform.rotation) as GameObject;
            delay = 0;
        } else
        {
            delay++;
        } 
    }

    public void Damage()
    {
        --health;
        --numberOfPepo;
        if (health == 0)
        {
            numberOfPepo = 0;
            Destroy(player);
        }
    }

}
