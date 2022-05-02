using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement; 


namespace Techability.Systems
{
    public class Month3Check : MonthCheckerAbstract
    {

        public Month3Check()
        {
            scriptableName = "Month3";
            base.EnsureSteps();
        }

        public override void CheckWeek1()
        {
            CheckW1S1();
        }

        public void CheckW1S1()
        {
            int week = 1;
            string step = "ARPG_W1S1";
            if (steps.GetStep(week, step).completed == true)
            {
                return;
            }

            Debug.Log("STEP HINT: Write the code needed to complete Level 01, then play the level");
        }

        public override void CheckWeek2()
        {
            CheckW2S1(); 
        }

        public void CheckW2S1()
        {
            int week = 2;
            string step = "ARPG_W2S1";
            if (steps.GetStep(week, step).completed == true)
            {
                return;
            }

            Debug.Log("STEP HINT: Write the code needed to complete Level 02, then play the level");
        }

        public override void CheckWeek3()
        {
            CheckW3S1();
        }

        void CheckW3S1()
        {
            int week = 3;
            string step = "ARPG_W3S1";
            if (steps.GetStep(week, step).completed == true)
            {
                return;
            }

            Debug.Log("STEP HINT: Write the code needed to complete Level 03, then play the level");
        }

        public override void CheckWeek4()
        {
            CheckW4S1();
            CheckW4S2();
            CheckW4S3();
        }

        void CheckW4S1()
        {
            int week = 4;
            string step = "ARPG_W4S1";
            if (steps.GetStep(week, step).completed == true)
            {
                return;
            }

            try
            {
                if (GameObject.Find("NavMesh Surface"))
                {
                    //Debug.Log("Week 1 - Step 1: Found Player Racer");

                    steps.GetStep(week, step).completed = true;
                    MonthChecker.AddPoints(steps.GetStep(week, step), this);
                }
                else
                {
                    Debug.Log("STEP HINT: When you add an item from the Heirachy tab, there is an AI category. The Nav Mesh Surface is in there.  ");
                }
            }
            catch { }
        }

        void CheckW4S2()
        {
            int week = 4;
            string step = "ARPG_W4S2"; 
            if (steps.GetStep(week, step).completed == true)
            {
                return;
            }

            try
            {
                GameObject obj = GameObject.Find("Obstacle - Bobber A"); 
                if (obj)
                {
                    bool HasNavComponet = false;
                    bool HasBobber = false;
                    bool hasCarveOn = false;

                    Bobber bob = obj.GetComponent<Bobber>(); 
                    if (bob)
                    {
                        HasBobber = true; 
                    }

                    NavMeshObstacle NMO = obj.GetComponent<NavMeshObstacle>(); 
                    if (NMO)
                    {
                        HasNavComponet = true; 
                        if (NMO.carving)
                        {
                            hasCarveOn = true; 
                        }
                    }



                    if ( HasBobber && HasNavComponet && hasCarveOn)
                    {
                        steps.GetStep(week, step).completed = true;
                        MonthChecker.AddPoints(steps.GetStep(week, step), this);
                        return;
                    }

                    if (!HasBobber)
                    {
                        Debug.Log("STEP HINT: Add a Bobber Script to 'Obstacle - Bobber A'");
                    }
                    if (!HasNavComponet)
                    {
                        Debug.Log("STEP HINT: Add a Nav Mesh Obstacle to 'Obstacle - Bobber A'");
                    }
                    if (!hasCarveOn)
                    {
                        Debug.Log("STEP HINT: Nav Mesh Obstacle Needs to have Carve on");
                    }

                }
                else
                {
                    Debug.Log("STEP HINT: The correct name for the object for step 2 is 'Obstacle - Bobber A'");
                }
            }
            catch { }
        }

        void CheckW4S3()
        {
            int week = 4;
            string step = "ARPG_W4S3";
            if (steps.GetStep(week, step).completed == true)
            {
                return;
            }

            Debug.Log("STEP HINT: Play Level 04 to complete this step");
            
        }
    }
}