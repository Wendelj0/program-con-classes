class custome
{
    //atribute
    string _headGear;

    string _shirt;

    string _pants;

    string _accessories;

    string _footwear;

    //behaviors

    void OutputReport()
    {
        string result;
        result = $"/nHead: {_headGear}/nShirt: {_shirt}/nPants: {_pants}/nAccessories: {_accessories}/nFootwear: {_footwear}";
        Console.WriteLine(result);
    }
}