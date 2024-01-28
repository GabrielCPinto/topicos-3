using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int countBanana = 0;

    [SerializeField] private Text BananasText;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Banana")){
            countBanana++;
            Destroy(collision.gameObject);
            BananasText.text = "Bananas: "+ countBanana;
        }
    }
}
