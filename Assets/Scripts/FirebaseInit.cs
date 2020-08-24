using System.Collections;
using System.Collections.Generic;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using Firebase.Analytics;
using UnityEngine;
using System;

public class FirebaseInit : MonoBehaviour
{
	private int initialPoints = -1;

	public int InitialPoints { get { return initialPoints; } }

	void Start()
    {
        // Set up the Editor before calling into the realtime database.
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://april-785ab.firebaseio.com/");

        // Get the root reference location of the database.
        DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;

        FirebaseDatabase.DefaultInstance
        .GetReference("player_score")
        .GetValueAsync().ContinueWith(task => {
            if (task.IsFaulted)
            {
                // Handle the error...
                Debug.Log("unable to retrieve database information");
            }
            else if (task.IsCompleted)
            {
				var snapshot = task.Result;
                initialPoints = Convert.ToInt32(snapshot.Value);

                //Dictionary<string, object> dict = new Dictionary<string, object>();
                //foreach (DataSnapshot child in snapshot.Children)
                //{
                //    dict.Add(child.Key, child.Value);
                //}
                //Debug.Log(dict.Values);
                //foreach(KeyValuePair<string, object> o in dict)
                //{
                //    Debug.Log(o.Value);
                //}
            }
        });
    }

    public void SavePoints(int points)
    {
        Debug.Log(points);
        // Set up the Editor before calling into the realtime database.
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://april-785ab.firebaseio.com/");

        // Get the root reference location of the database.
        DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;

        reference.Child("player_score").SetValueAsync(points.ToString());
    }

}
