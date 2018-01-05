using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class givemoji : MonoBehaviour {
	public static string give;
	public static int len;
	public ParticleSystem a;
	// Use this for initialization
	void Start () {
		var emitParams = new ParticleSystem.EmitParams();
		give="おそまつ";
		if (give != null)
		{

			//文字数を取得
			a.Emit(emitParams, give.Length);
			//ParticleSystem.Burst(0.0f, give.Length);
			//Debug.Log (give.Length);
			a.Play();
		}
	}
	
	// Update is called once per frame
	void Update () {


}

}
