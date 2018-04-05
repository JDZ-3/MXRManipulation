using UnityEngine;
using Spawnable;
using ResultTracker;
using DraggedObj;

public class CollisionScript : MonoBehaviour
{
    public Vector3 initPos;
    private dataTracker results;
    //private HandDragging obj;

    // Use this for initialization
    void Start () {
        results = GameObject.Find("[Study]").GetComponent<dataTracker>();
        initPos = this.transform.position;
        //obj = new HandDragging();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == this.gameObject.name + "_bucket")
        {
            Destroy(this.gameObject);
            results.Hit++;
            results.Total_pegs++;
            results.Distance = Vector3.Distance(initPos, collision.transform.position);
            results.endInteraction(this.gameObject.name, initPos);

            if (results.Hit == 3)
                NewObjs();
        }
        else
        {
            string name = this.gameObject.name;
            GameObject replace = Instantiate(this.gameObject, initPos, Quaternion.identity);
            Destroy(this.gameObject);
            replace.name = name;
            results.Wrong_pegs++;
        }
    }

    public void NewObjs()
    {
        GameObject.Find("[Study]").GetComponent<SpawnableObjects>().SpawnObjs();
        results.Hit = 0;
    }
}