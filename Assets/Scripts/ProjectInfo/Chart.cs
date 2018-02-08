﻿using System.Collections.Generic;

[System.Serializable]
public class ChartV1 //Saves info of a single chart
{
    public float speed = 0; //Speed value of the official charts
    public int difficulty = 0; //Difficulty 0 Easy, 1 Normal, 2 Hard, 3 Extra
    public string level = ""; //Level of the chart, for example, L
    public List<float> beats = new List<float>(); //For quantizing the note
    public List<Note> notes = new List<Note>(); //All the notes info
}

[System.Serializable]
public class ChartV2
{
    public float speed = 0;
    public int difficulty = 0;
    public string level = "";
    public List<TempoEvent> tempoEvents = new List<TempoEvent>(); // Events for tempo changing
    public List<Note> notes = new List<Note>();
}

public class TempoEvent
{
    public float time; // If free->restricted, at what time
    public float bpm; // Tempo after the event, not used if free = true
}

[System.Serializable]
public class Note //A class that saves info of a note
{
    public float position = 0.0f; //pos
    public float size = 0.0f; //size
    public float time = 0.0f; //_time
    public float shift = 0.0f; //shift
    public List<PianoSound> sounds = new List<PianoSound>(); //sounds
    public bool isLink = false; //Whether the note is a link note
    //The two variables below are not used when isLink=false
    public int prevLink = -1; //Index of previous link note in the same link, -1 means current note is the first
    public int nextLink = -1; //Index of next link note in the same link, -1 means current note is the last
}

[System.Serializable]
public class PianoSound //Saves info of a piano sound
{
    public float delay = 0.0f; //w
    public float duration = 0.0f; //d
    public int pitch = 0; //p
    public int volume = 0; //v
}