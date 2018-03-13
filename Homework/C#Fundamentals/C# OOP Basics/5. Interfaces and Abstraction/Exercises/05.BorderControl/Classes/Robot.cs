using System;
using System.Collections.Generic;
using System.Text;

public class Robot : IRobot, IId
{
    private string model;
    private string id;

    public Robot(string model, string id)
    {
        this.Model = model;
        this.ID = id;
    }

    public string Model
    {
        get { return model; }
        private set { model = value; }
    }

    public string ID
    {
        get { return id; }
        private set { id = value; }
    }
}

