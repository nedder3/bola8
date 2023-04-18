using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
     {
        //reset scene
        SceneManager.LoadScene(0);
     }


    // Update is called once per frame
    void Update()
    {
        //movement to left
        if(Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * 500 * Time.deltaTime);
        }

         //movement to right
        if(Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 500 * Time.deltaTime);
        }

           //movement to foward
        if(Input.GetKey(KeyCode.W))
        {
           transform.Translate(Vector3.forward * 5 *Time.deltaTime);
        }

        
    }
}
