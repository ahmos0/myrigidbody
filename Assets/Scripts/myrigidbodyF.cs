using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myrigidbodyF : MonoBehaviour
{
	public Vector3 a;	//aは加速度

	public Vector3 v;	//vは速度
	public Vector3 p;	//pは物体の位置

	public float m;	//mは質量
	public Vector3 g;	//gは重力加速度

	const float dt = 1f/60f;	//微小時間dt frame rate を考える 
	public void AddForce(Vector3 f)
    {
        //fは力のこと
		a += f / m;	//加速度aを増やすためにfを加える
	}
	
	void FixedUpdate ()
    {

		a += g; 

		v += a * dt;	//加速度aを時間積分
		p += v * dt;	//速度vを時間積分
		transform.position = p;
		a = Vector3.zero;	//加速度をリセット。加えた力の影響を最後にリセット	
	}
}
