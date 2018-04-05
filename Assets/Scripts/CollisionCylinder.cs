using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCylinder : MonoBehaviour {

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name == "cylinder_bucket1" && this.gameObject.name == "cylinder1")
    //    {
    //        Destroy(this.gameObject);
    //        Debug.Log("hit clyinder 1");
    //        makeNew();
    //    }

    //    if (collision.gameObject.name == "cylinder_bucket2" && this.gameObject.name == "cylinder2")
    //    {
    //        Destroy(this.gameObject);
    //        Debug.Log("hit clyinder 2");
    //        makeNew2();
    //    }

    //    if (collision.gameObject.name == "cylinder_bucket3" && this.gameObject.name == "cylinder3")
    //    {
    //        Destroy(this.gameObject);
    //        Debug.Log("hit clyinder 3");
    //        makeNew3();
    //    }
    //}

    //private void makeNew()
    //{
    //    //make new object appear somewhere elses
    //    GameObject cylinder1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
    //    cylinder1.name = "cylinder1";
    //    cylinder1.AddComponent<Rigidbody>();
    //    cylinder1.GetComponent<Rigidbody>().useGravity = false;
    //    cylinder1.transform.position = new Vector3(2, 0, -2);
    //    cylinder1.GetComponent<Renderer>().material.color = Color.red;
    //    cylinder1.AddComponent<HandDragging>();
    //    cylinder1.AddComponent<CollisionCylinder>();
    //    cylinder1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    //    cylinder1.transform.localScale = new Vector3(.25f, .25f, .25f);

    //}

    //private void makeNew2()
    //{
    //    //make new object appear somewhere elses
    //    GameObject cylinder2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
    //    cylinder2.name = "cylinder2";
    //    cylinder2.AddComponent<Rigidbody>();
    //    cylinder2.GetComponent<Rigidbody>().useGravity = false;
    //    cylinder2.transform.position = new Vector3(4, 0, -2);
    //    cylinder2.GetComponent<Renderer>().material.color = Color.blue;
    //    cylinder2.AddComponent<HandDragging>();
    //    cylinder2.AddComponent<CollisionCylinder>();
    //    cylinder2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    //    cylinder2.transform.localScale = new Vector3(.25f, .25f, .25f);

    //}

    //private void makeNew3()
    //{
    //    //make new object appear somewhere elses
    //    GameObject cylinder3 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
    //    cylinder3.name = "cylinder3";
    //    cylinder3.AddComponent<Rigidbody>();
    //    cylinder3.GetComponent<Rigidbody>().useGravity = false;
    //    cylinder3.transform.position = new Vector3(6, 0, -2);
    //    cylinder3.GetComponent<Renderer>().material.color = Color.yellow;
    //    cylinder3.AddComponent<HandDragging>();
    //    cylinder3.AddComponent<CollisionCylinder>();
    //    cylinder3.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    //    cylinder3.transform.localScale = new Vector3(.25f, .25f, .25f);

    //}
}
