using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;
    public float hiz;
    public float hiz2;

    void Start()
    {
        
    }

    void Update()
    {

        enemy1.transform.Translate(-hiz2 * Time.deltaTime, 0, 0);

        if (enemy1.transform.position.x <= -8.5f)
        {
            float konum = Random.Range(13.3f, 18);
            enemy1.transform.position = new Vector3(konum, 0.72f, 0.41f);
        }
        enemy2.transform.Translate(hiz * Time.deltaTime, 0, 0);

        if (enemy2.transform.position.x >= 14f)
        {
            float konum = Random.Range(-8.53f, -10.5f);
            enemy2.transform.position = new Vector3(konum, 0.72f, 0.41f);
        }
    }


}
