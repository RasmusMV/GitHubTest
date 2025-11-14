using System;

public class RandomClass
{
    string _name;
    string _gender;
    public RandomClass(string name, string gender)
	{
        _name = name;
        _gender = gender;
	}

    public string Name
    {
        get { return _name; }
    }


}
