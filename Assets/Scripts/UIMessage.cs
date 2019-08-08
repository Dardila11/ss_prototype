using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMessage : MonoBehaviour {
    public GameObject message;
    // Start is called before the first frame update
    void Start() {
        message.SetActive(false);
    }

    void OnTriggerEnter(Collider player){
        if(player.gameObject.tag == "Player"){
            message.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }

    IEnumerator WaitForSec(){
        yield return new WaitForSeconds(3);
        Destroy(message);
        
    }

    // Update is called once per frame
    void Update() {

    }
}
