using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor.VersionControl;

public class DC : MonoBehaviour {
    public GameObject task;
	// Use this for initialization
	void Start () {
        StartCoroutine(DelayToInvokeDo(delegate() {
            task.SetActive(true);
            task.transform.position = Vector3.zero;
            task.transform.rotation = Quaternion.Euler(Vector3.zero);
        } , 1.5f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public IEnumerator DelayToInvokeDo(Action action , float delaySecond) 
    {
        yield return new WaitForSeconds(delaySecond);
        action();
    }
    
}
