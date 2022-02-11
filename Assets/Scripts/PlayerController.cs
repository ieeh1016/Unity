using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class Tank
{
    public float speed = 10.0f;
}

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 15.0f;

    void Start()
    {
        Managers.Input.KeyAction -= OnKeyboard;
        Managers.Input.KeyAction += OnKeyboard;

        Tank tank1 = new Tank(); // Instance를 만든다
        Tank tank2 = new Tank(); // Instance를 만든다
        Tank tank3 = new Tank(); // Instance를 만든다
        Tank tank4 = new Tank(); // Instance를 만든다
        Tank tank5 = new Tank(); // Instance를 만든다
    }


    void Update()
    {
        
        
    }
    void OnKeyboard()
    {
        if (Input.GetKey(KeyCode.W))
        {

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.2f);
            transform.position += Vector3.forward * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.S))
        {

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.2f);
            transform.position += Vector3.back * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.A))
        {

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.2f);
            transform.position += Vector3.left * Time.deltaTime * _speed;
        }

        if (Input.GetKey(KeyCode.D))
        {

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.2f);
            transform.position += Vector3.right * Time.deltaTime * _speed;
        }
    }
}
