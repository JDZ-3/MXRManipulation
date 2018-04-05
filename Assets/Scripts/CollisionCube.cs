using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCube : MonoBehaviour {

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name == "cube_bucket1" && this.gameObject.name == "cube1") { 
    //        Destroy(this.gameObject);
    //        makeNew();
    //    }

    //    if (collision.gameObject.name == "cube_bucket2" && this.gameObject.name == "cube2")
    //    {
    //        Destroy(this.gameObject);
    //        Debug.Log("hit cube 2");
    //        makeNew2();
    //    }

    //    if (collision.gameObject.name == "cube_bucket3" && this.gameObject.name == "cube3" )
    //    {
    //        Destroy(this.gameObject);
    //        Debug.Log("hit cube 3");
    //        makeNew3();
    //    }
    //}

    //private void makeNew()
    //{
    //        //make new object appear somewhere elses
    //        GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
    //        cube1.name = "cube1";
    //        cube1.AddComponent<Rigidbody>();
    //        cube1.GetComponent<Rigidbody>().useGravity = false;
    //        cube1.transform.position = new Vector3(2, 0, 0);
    //        cube1.GetComponent<Renderer>().material.color = Color.red;
    //        cube1.AddComponent<HandDragging>();
    //        cube1.AddComponent<CollisionCube>();
    //        cube1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    //    cube1.transform.localScale = new Vector3(.25f, .25f, .25f);

    //    print("hit cube 1");
    //}

    //private void makeNew2()
    //{
    //    //make new object appear somewhere elses
    //    GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
    //    cube2.name = "cube2";
    //    cube2.AddComponent<Rigidbody>();
    //    cube2.GetComponent<Rigidbody>().useGravity = false;
    //    cube2.transform.position = new Vector3(4, 0, 0);
    //    cube2.GetComponent<Renderer>().material.color = Color.blue;
    //    cube2.AddComponent<HandDragging>();
    //    cube2.AddComponent<CollisionCube>();
    //    cube2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    //    cube2.transform.localScale = new Vector3(.25f, .25f, .25f);

    //}

    //private void makeNew3()
    //{
    //    //make new object appear somewhere elses
    //    GameObject cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
    //    cube3.name = "cube3";
    //    cube3.AddComponent<Rigidbody>();
    //    cube3.GetComponent<Rigidbody>().useGravity = false;
    //    cube3.transform.position = new Vector3(6, 0, 0);
    //    cube3.GetComponent<Renderer>().material.color = Color.yellow;
    //    cube3.AddComponent<HandDragging>();
    //    cube3.AddComponent<CollisionCube>();
    //    cube3.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    //    cube3.transform.localScale = new Vector3(.25f, .25f, .25f);

    //}
}
