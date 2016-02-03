using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MerchantShop : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerStay2D(Collider2D other)
    {
       
        if (Input.GetKey(KeyCode.E) == true)
        {

            SceneManager.LoadScene("ShopScene");
            
        }

    }
}
