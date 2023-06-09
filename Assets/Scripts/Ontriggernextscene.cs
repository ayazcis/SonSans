using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ontriggernextscene : MonoBehaviour
{
    public GameObject objectToActivate; // etkinleştirilecek game object

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player")) // etkileşim sağlandığında sadece "Player" nesnesi için geçerli olduğunu kontrol ediyoruz
        {
            objectToActivate.SetActive(true); // objectToActivate değişkenindeki oyun nesnesini etkinleştiriyoruz

        }
    }
}
