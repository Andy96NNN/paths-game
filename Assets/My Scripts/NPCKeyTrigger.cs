using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class NPCKeyTrigger : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public KeyCode continueKey;
    public UnityEvent interactAction; 
    public UnityEvent continueAction; 

    // Update is called once per frame
    void Update() 
    {
        if (isInRange) {
            if (Input.GetKeyDown(interactKey)){
                interactAction.Invoke();
            }
            if (Input.GetKeyDown(continueKey))
            {
                continueAction.Invoke();
            }
        }
    }

    private void OnTriggerEnter(Collider collision){

        if (collision.gameObject.CompareTag("Player")){
            isInRange = true;
            Debug.Log("Player in range");
        }
    }
    private void OnTriggerExit(Collider collision){

        if (collision.gameObject.CompareTag("Player")){
            isInRange = false;
            Debug.Log("Player not in range");
        }
    }
}
