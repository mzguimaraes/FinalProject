using UnityEngine;
using System.Collections;

public class NodeController : MonoBehaviour {

	public GameObject player;
	public GameObject nodePrefab;

	void OnTriggerEnter2D(Collider2D activator) {
		// if the activator is the player
		if(activator.gameObject == player){
			if(Input.GetKeyDown(KeyCode.Space)){
				// if the player presses space, create 

			}
		}
    }
}
