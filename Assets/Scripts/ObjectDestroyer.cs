using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Уничтожает игровой объект в начале игры
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
