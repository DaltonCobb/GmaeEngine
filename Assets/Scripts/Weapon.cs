using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject _bullet;
    
    void Start()
    {
        
    }

     void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Vector3 direction = (point - transform.position).normalized;

            GameObject gameObject = Instantiate(_bullet, transform.position, Quaternion.identity);
            gameObject.GetComponent<Bullet>().Fire(ray.direction);
            //Destroy(gameObject, 3);
        }
    }
}
