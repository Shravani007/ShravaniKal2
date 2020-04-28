class HelloWorld {
    static void Main() {
        string str = "3+3*3+3";
        int tmpValue;
        Stack s = new Stack();
        int i=0;
        while(i <= str.Length-1)
        {
            switch((char)str[i])
            {
                case '+':
                    break;
                case '*' :
                    tmpValue = int.Parse(s.Pop().ToString());
                    //Console.WriteLine(str[i+1] + "  " + tmpValue);
                    tmpValue = tmpValue * int.Parse((str[i+1]).ToString());
                    //Console.WriteLine(int.Parse(str[i+1].ToString()) + "  " + tmpValue.ToString());
                    s.Push(tmpValue);
                    break;
                default :
                    //Console.WriteLine("Pushing" + str[i]);
                    s.Push(int.Parse(str[i].ToString()));
                    break;
            }
            i++;
        }
        int result=0;
        while(s.Count > 0)
        {
            result += (int)s.Pop(); 
        }
        Console.WriteLine("Result  = {0}", result);
    }
}
