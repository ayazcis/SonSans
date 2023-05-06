using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Ball : MonoBehaviour
{
    public AudioSource gotkey;
    public GameObject door;
    public GameObject key;
    public GameObject doorsCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("key"))
		{
            gotkey.Play();
            Destroy(key);
            Destroy(door);
            Destroy(doorsCollider);
		}
        if (collision.gameObject.CompareTag("out"))
        {
            //SceneManager.LoadScene();
        }
    }

}
