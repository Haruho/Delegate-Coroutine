using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 定义一个协程
/// </summary>
public class Coroutine : MonoBehaviour {
    //定一个一个协程   不同于定义类或者委托，此时的协程是可以直接使用的，Unity的每一个执行周期中都回1包含属于协程的那一部分，只要是场景中处于激活状态的物体（Active是True）
    //Unity在渲染·的每一个周期中东都会检查物体上有没有协程的代码。若存在则加入该物体协程的执行周期   当然active是false的物体上的协程是不会被执行的
   // public IEnumerator MyCoroutine() { };
	// Use this for initialization
	void Start () {
	}

    private IEnumerator MyCoroutine()
    {
        print("123123123");
        yield return new WaitForSeconds(3);
    }

    // Update is called once per frame
    void Update () {
        StartCoroutine(MyCoroutine());
    }
}
