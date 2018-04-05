using UnityEngine;
using UnityEngine.UI;


public class UpdateTime : MonoBehaviour {

    private int min = 3;
    private int sec = 0;
    private float start;
    private bool end;

	// Use this for initialization
	void Start () {
        end = false;
        start = Time.time;
        this.GetComponent<Text>().text = "Time: 3:00";
    }

    // Update is called once per frame
    void Update () {
        sec = 60 - ((int)(Time.time - start) % 60);
        if (sec == 60) sec = 0;

        if ((int)(Time.time - start) > 60 && (int)(Time.time - start) < 120)
            min = 1;
        else if ((int)(Time.time - start) > 120 && (int)(Time.time - start) < 180)
            min = 0;
        else if ((int)(Time.time - start) < 60 && (int)(Time.time - start) > 0.5f)
            min = 2;
        else if ((int)(Time.time - start) < 0.5f)
            min = 3;


        this.GetComponent<Text>().text = "Time: " + min.ToString() + ":" + sec.ToString("00");

        if((Time.time - start) > 180 && !end)
        {
            ClearVis();
            end = !end;
        }
        else if((Time.time - start) > 180)
        {
            this.GetComponent<Text>().text = "Time: 0:00";
        }
    }

    private void ClearVis()
    {
        GameObject.Find("MetaHands").SetActive(false);
    }
}
