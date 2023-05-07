using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ontriggernextscene : MonoBehaviour
{
    public GameObject objectToActivate; // etkinleþtirilecek game object

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player")) // etkileþim saðlandýðýnda sadece "Player" nesnesi için geçerli olduðunu kontrol ediyoruz
        {
            objectToActivate.SetActive(true); // objectToActivate deðiþkenindeki oyun nesnesini etkinleþtiriyoruz

        }
    }
}
