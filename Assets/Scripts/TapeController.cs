﻿namespace VRTK
{
    using UnityEngine;

    public class TapeController : MonoBehaviour
    {

        private Rigidbody rb;

        public bool wireFixed;

        // Use this for initialization
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            wireFixed = false;
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("BrokenWire"))
            {
                GameObject[] brokenWires = GameObject.FindGameObjectsWithTag("BrokenWire");
                for (int i = 0; i < brokenWires.Length; i++)
                {
					brokenWires[i].GetComponent<SkinnedMeshRenderer> ().enabled = false;
                }
				GameObject healthywire = GameObject.FindGameObjectWithTag("HealthyWire");
				healthywire.GetComponent<SkinnedMeshRenderer> ().enabled = true;
                wireFixed = true;
            }
        }
    }
}
