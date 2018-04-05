using UnityEngine;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Spawnable;

namespace ResultTracker
{
    class dataTracker : MonoBehaviour
    {
        private bool done;
        private int num_clicks, total_pegs, wrong_pegs, hit;
        private float start_t, end_t, start_interaction, end_interaction, distance;
        //private List<float> interactions;//, distances;
        private List<string> writeOut;
        private SpawnableObjects spawning;
        //float total_time_pegs;
        StreamWriter writer;

        //public string participant_no;
        //public string type;

        void Start()
        {
            done = false;
            total_pegs = 0;
            num_clicks = 0;
            wrong_pegs = 0;
            hit = 0;
            //interactions = new List<float>();
            //distances = new List<float>();
            writeOut = new List<string>();
            spawning = GameObject.Find("[Study]").GetComponent<SpawnableObjects>();

            writeOut.Add("Round, Object, Initial Position, Interaction Time, Interaction Distance");//\r\n");
            //total_time_pegs = 0;
            //participant_no = "";
            //type = "";
            //            openFile();
            //           StartCoroutine(Example());
        }

        void Update()
        {
            end_t = Time.time;
            if ((end_t - start_t) >= 180 && !done)
            {
                endGame();
                done = true;
            }
        }

        public int Total_pegs { get { return total_pegs; } set { total_pegs = value; } }
        public int Wrong_pegs { get { return wrong_pegs; } set { wrong_pegs = value; } }
        public int Num_clicks { get { return num_clicks; } set { num_clicks = value; } }
        public int Hit { get { return hit; } set { hit = value; } }
        public float Distance { get { return distance; } set { distance = value; } }
        public float Start_t { get; set; }
        public float End_t { get; set; }

        private void openFile()
        {
            string path = @"C:\Users\ruizlab\Desktop\test.txt";// + participant_no + "_" + type + ".txt";
            writer = new StreamWriter(path, true);
        }
        private void closeFile() { writer.Close(); }
        public void beginGame() { start_t = Time.time; }
        public void startInteraction() { start_interaction = Time.time; }

        public void endInteraction(string name, Vector3 initPos)
        {
            end_interaction = Time.time;
            writeOut.Add(spawning.Round.ToString() + ", " + name + ", " + initPos.ToString() + ", " +
                (end_interaction - start_interaction).ToString() + ", " + distance.ToString());// + "\r\n");
        }

        public void endGame()
        {
            //end_t = Time.time;
            writeOut.Add("");
            writeOut.Add("Total Time, Total Objects Placed, Total Objects Misplaced, Number of Clicks, Optimal Clicks");//\r\n");
            writeOut.Add(((int)(end_t - start_t)).ToString() + ", " + total_pegs.ToString() + ", " +
                wrong_pegs.ToString() + ", " + num_clicks.ToString() + ", " + total_pegs.ToString());// + "\r\n");

            openFile();
            foreach (string line in writeOut)
            {
                Debug.Log(line);
                writer.WriteLine(line);
            }
            closeFile();
        }

        //     public void countPegs()
        //     {
        //         total_pegs++;
        //         //Output to file at the end of the game
        ////Written to file in overallTime 
        //     }

   //     public void overallTime(float final_t)
   //     {
   //         float overall_t;
   //         final_t = Time.time;
   //         overall_t = final_t - start_t;
   //         //Output to file at the end of the game
			//writer.WriteLine("Number of Clicks: " + num_clicks + "\r\n");
			//writer.WriteLine("Total Number of Pegs: " + total_pegs + "\r\n");
			//writer.WriteLine("Error - Number of Pegs: " + wrong_pegs + "\r\n");
			//writer.WriteLine("Start Time of Game: " + start_t + " End Time of Game: " + final_t + "\r\n");
   //     }

   //     public void numClicks()
   //     {
   //         num_clicks++;
   //         //Output to file at the end of the game
			////Written to file in overallTime
   //     }

        //public void beginInteraction()
        //{
        //    start_interaction = Time.time;
        //}

    //    public void recordTime(bool isCorrect)
    //    {
    //        if (isCorrect)
    //        {
    //            float end_interaction = Time.time;
				////Output to file
    //            writer.WriteLine(start_interaction + "," + end_interaction + "\r\n");
                
    //            //total_time_pegs += (end_interaction - start_interaction);
    //        }
    //        else
    //            return;
    //    }

//        public void avgTime()
//        {
////            float avgTime = total_time_pegs / total_pegs;
//            //Output to file at the end of the game
//	//		writer.WriteLine("Average Time Per Peg" + avgTime + "\r\n");
//        }

   //     public void error()
   //     {
   //         wrong_pegs++;
   //         //Output to file at the end of the game
			////Written to file in overallTime
   //     }

        //IEnumerator Example()
        //{
        //    //beginInteraction();
        //    startInteraction();
        //    yield return new WaitForSeconds(5);
        //    recordTime(true);
        //    closeFile();
        //}
    }
}