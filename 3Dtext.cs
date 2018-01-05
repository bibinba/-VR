using UnityEngine;
using System.Collections;
using PowerUI;
using FrostweepGames.Plugins.GoogleCloud.SpeechRecognition.aa;

public class dtext : MonoBehaviour {

	/// <summary>Messages to cycle through.</summary>
	//public string Messages;
	/// <summary>The current index in the messages.</summary>

	void Start(){

	}
	void Update(){
		var document = GetComponent<PowerUI.Manager>().Document;

		var msg=document.getElementById("message");
		msg.addEventListener("animationiteration",delegate(PowerUI.AnimationEvent e){

			// Write out the next message:
			msg.innerHTML=aa.kekka;
			Debug.Log(msg.innerHTML);
			// Cycle index:

		});
	}


}
