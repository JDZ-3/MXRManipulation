using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSphere : MonoBehaviour {

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name == "sphere_bucket1" && this.gameObject.name == "sphere1")
    //    {
    //        Destroy(this.gameObject);
    //        Debug.Log("hit sphere 1");
    //        makeNew();
    //    }

    //    if (collision.gameObject.name == "sphere_bucket2" && this.gameObject.name == "sphere2")
    //    {
    //        Destroy(this.gameObject);
    //        Debug.Log("hit sphere 2");
    //        makeNew2();
    //    }

    //    if (collision.gameObject.name == "sphere_bucket3" && this.gameObject.name == "sphere3")
    //    {
    //        Destroy(this.gameObject);
    //        Debug.Log("hit sphere 3");
    //        makeNew3();
    //    }
    //}

    //private void makeNew()
    //{
    //    //make new object appear somewhere elses
    //    GameObject sphere1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
    //    sphere1.name = "sphere1";
    //    sphere1.AddComponent<Rigidbody>();
    //    sphere1.GetComponent<Rigidbody>().useGravity = false;
    //    sphere1.transform.position = new Vector3(2, 0, -4);
    //    sphere1.GetComponent<Renderer>().material.color = Color.red;
    //    sphere1.AddComponent<HandDragging>();
    //    sphere1.AddComponent<CollisionSphere>();
    //    sphere1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    //    sphere1.transform.localScale = new Vector3(.25f, .25f, .25f);

    //}

    //private void makeNew2()
    //{
    //    //make new object appear somewhere elses
    //    GameObject sphere2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
    //    sphere2.name = "sphere2";
    //    sphere2.AddComponent<Rigidbody>();
    //    sphere2.GetComponent<Rigidbody>().useGravity = false;
    //    sphere2.transform.position = new Vector3(4, 0, -4);
    //    sphere2.GetComponent<Renderer>().material.color = Color.blue;
    //    sphere2.AddComponent<HandDragging>();
    //    sphere2.AddComponent<CollisionSphere>();
    //    sphere2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    //    sphere2.transform.localScale = new Vector3(.25f, .25f, .25f);

    //}

    //private void makeNew3()
    //{
    //    //make new object appear somewhere elses
    //    GameObject sphere3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
    //    sphere3.name = "sphere3";
    //    sphere3.AddComponent<Rigidbody>();
    //    sphere3.GetComponent<Rigidbody>().useGravity = false;
    //    sphere3.transform.position = new Vector3(6, 0, -4);
    //    sphere3.GetComponent<Renderer>().material.color = Color.yellow;
    //    sphere3.AddComponent<HandDragging>();
    //    sphere3.AddComponent<CollisionSphere>();
    //    sphere3.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    //    sphere3.transform.localScale = new Vector3(.25f, .25f, .25f);

    //}
}
