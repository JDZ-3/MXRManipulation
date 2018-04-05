using UnityEngine;
using UnityEngine.UI;
using ResultTracker;

public class UpdatePlaced : MonoBehaviour {

    private dataTracker results;

	// Use this for initialization
	void Start () {
        results = GameObject.Find("[Study]").GetComponent<dataTracker>();
    }

    // Update is called once per frame
    void Update () {
        this.GetComponent<Text>().text = "Objects Placed: " + results.Total_pegs.ToString();
    }
}
