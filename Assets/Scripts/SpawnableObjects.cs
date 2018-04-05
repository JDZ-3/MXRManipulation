using UnityEngine;

namespace Spawnable
{
    public class SpawnableObjects : MonoBehaviour
    {

        public GameObject[] objs;
        public Material[] mats;
        private int round;
        private Vector3[] pos = { new Vector3(-0.25f, -.25f, .3f), new Vector3(0f, -.25f, .3f), new Vector3(0.25f, -.25f, .3f) };

        // Use this for initialization
        void Start()
        {
            round = 0;
            SpawnObjs();
        }

        public int Round { get { return round; } set { round = value; } }

        public void SpawnObjs()
        {
            for (int i = 0; i < pos.Length; i++)
            {
                int o = Random.Range(0, objs.Length);
                int c = Random.Range(0, mats.Length);
                GameObject g = Instantiate(objs[o], pos[i], Quaternion.identity);
                g.GetComponent<Renderer>().material = mats[c];
                g.name = objs[o].name + "_" + mats[c].name;
            }

            round++;

            //int o1 = Random.Range(0, objs.Length);
            //int o2 = Random.Range(0, objs.Length);
            //int o3 = Random.Range(0, objs.Length);

            //int c1 = Random.Range(0, mats.Length);
            //int c2 = Random.Range(0, mats.Length);
            //int c3 = Random.Range(0, mats.Length);

            //GameObject g1 = Instantiate(objs[o1], pos[0], Quaternion.identity);
            //g1.GetComponent<Renderer>().material = mats[c1];
            //g1.name = objs[o1].name + "_" + mats[c1].name;

            //GameObject g2 = Instantiate(objs[o2], pos[1], Quaternion.identity);
            //g2.GetComponent<Renderer>().material = mats[c2];
            //g2.name = objs[o2].name + "_" + mats[c2].name;

            //GameObject g3 = Instantiate(objs[o3], pos[2], Quaternion.identity);
            //g3.GetComponent<Renderer>().material = mats[c3];
            //g3.name = objs[o3].name + "_" + mats[c3].name;
        }
    }
}