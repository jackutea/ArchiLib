using System;
using UnityEngine;
using ArchiLib;

namespace Sample {

    public class App : MonoBehaviour {

        void Awake() {

            int[] arr = new int[3] {
                1,
                2,
                3,
            };

            Debug.Log(arr.ToArrayString());

        }

    }

}