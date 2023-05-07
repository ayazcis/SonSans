using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ontriggernextscene : MonoBehaviour
{
    public GameObject objectToActivate; // etkinle�tirilecek game object

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player")) // etkile�im sa�land���nda sadece "Player" nesnesi i�in ge�erli oldu�unu kontrol ediyoruz
        {
            objectToActivate.SetActive(true); // objectToActivate de�i�kenindeki oyun nesnesini etkinle�tiriyoruz

        }
    }
}
