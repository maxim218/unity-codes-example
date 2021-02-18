using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsControl : MonoBehaviour {
    void OnGUI() {
        if (GUI.Button(new Rect(50, 100, 200, 50), "Run A")) RunTheSound("A");
        if (GUI.Button(new Rect(50, 200, 200, 50), "Run B")) RunTheSound("B");
        if (GUI.Button(new Rect(50, 300, 200, 50), "Run C")) RunTheSound("C");
        if (GUI.Button(new Rect(300, 100, 200, 50), "Stop all sounds")) StopAllSounds();
    }
    
    private void RunTheSound(string soundName) {
        RunnerSounds script = gameObject.GetComponent<RunnerSounds>();
        script.SoundThisRun(soundName);
    }

    private void StopAllSounds() {
        RunnerSounds script = gameObject.GetComponent<RunnerSounds>();
        script.StopTheSounds();
    }
}
