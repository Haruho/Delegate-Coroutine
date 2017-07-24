using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDelegate : MonoBehaviour {
    //声明一个委托，如同定义一个类一样，此时的委托没有经过实例化是无法使用的，而他的实例化必须接受一个返回值和蚕食都等同于他的函数  此处的委托MyDelegate只能接受返回值是void  参数是int的函数
    public delegate void MyDelegate(int _num);
	// Use this for initialization
	void Start () {
        //以testMethod实例化一个MyDelegate类型的委托_myDelegate   注意观察TestMethod的定义
        MyDelegate _myDelegate = new MyDelegate(TestMethod);


        //调y用_myDelegate就相当于调用TestMethod（）；
        _myDelegate(10);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void TestMethod(int num)
    {
        print(num * 2);
    }
}
