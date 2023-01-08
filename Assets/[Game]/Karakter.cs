using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Karakter : MonoBehaviour
{
    public float hiz;
    public Animator anim;
    private Rigidbody rigid;
    private bool isJump = false;
    public float jump;
    private int can = 0;
    public Image kalp1;
    public Image kalp2;
    public Image kalp3;
    public GameObject menu;
    public GameObject devamet;
    public GameObject kaybettin;
    public GameObject kazandin;

    void Start()
    {
        rigid= GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
            anim.SetTrigger("run");
            transform.Translate(0, 0, hiz * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Transform>().localScale = new Vector3(1, 1, -1);
            anim.SetTrigger("run");
            transform.Translate(0, 0, -hiz * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (isJump==false)
            {
                anim.SetTrigger("jump");
                rigid.AddForce(Vector3.up * jump);
                isJump = true;
            }
        }
        if (Input.GetKey(KeyCode.RightArrow) == false && (Input.GetKey(KeyCode.LeftArrow) == false))
        {
            anim.SetTrigger("idle");
        }

        float xPozisyon = Mathf.Clamp(transform.position.x, -3.45f, 13f );
        transform.position = new Vector3(xPozisyon,transform.position.y, transform.position.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isJump = false;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            can = can + 1;
            if (can==1)
            {
                kalp1.color= Color.black;
            }
            if (can == 2)
            {
                kalp2.color = Color.black;
            }
            if (can == 3)
            {
                kalp3.color = Color.black;

                Time.timeScale = 0f;
                menu.SetActive(true);
                devamet.SetActive(false);
                kaybettin.SetActive(true);
                kazandin.SetActive(false);

            }
        }
    }
}
