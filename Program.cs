class Program 
{
    public static string InputName()
    {
        Console.Write("input name: ");
        return Console.ReadLine();
    }
    public static string InputScore(){
        Console.Write("input Score:");
        return Console.ReadLine();
    }
    public static int ConvertStringToInt(string value){
        if(int.TryParse(value,out int number)){
            return number;
        }
        throw new Exception("Wrong Word");
    }
    public static string ConvertScoreToGrade(int score){
        if (score > 100){ throw new Exception("Over 100");}
        else if (IsGradeA(score)){
            return "Grade A";
        } else if (IsGradeBPlus(score)){
            return "Grade B+";
        } else if (IsGradeB(score)){
            return "Grade B";
        } else if (IsGradeCPlus(score)){
            return "Grade C+";
        } else if (IsGradeC(score)){
            return "Grade C";
        } else if (IsGradeDPlus(score)){
            return "Grade D+";
        } else if (IsGradeD(score)){
            return "Grade D";
        } else {
            return "You F";
        }

    }
    public static bool IsGradeA(int score){
        return score <= 100 && score >= 80;
    }
    public static bool IsGradeBPlus(int score){
        return score < 80 && score >= 75;
    }
    public static bool IsGradeB(int score){
        return score < 75 && score >= 70;
    }
    public static bool IsGradeCPlus(int score){
        return score < 70 && score >= 65;
    }
    public static bool IsGradeC(int score){
        return score < 65 && score >= 60;
    }
    public static bool IsGradeDPlus(int score){
        return score < 60 && score >= 55;
    }
    public static bool IsGradeD(int score){
        int MaxD = 54;
        int MinD = 50;
        return score <= MaxD && score >= MinD;
    }
    public static bool IsGradeF(int score){
        return score < 60;
    }
    static void dokjun(){
        Console.WriteLine("*************************");
    }
    static void PrintInputInformation(string name, string InputScore,string grade){
        Console.WriteLine();
        Console.WriteLine("Name is: {0}",name);
        dokjun();
        Console.WriteLine("Score is: {0}",InputScore);
        Console.WriteLine("Grade is: {0}",grade);
        dokjun();
    }
    static void Main(String[] args)
    {
        string name = InputName();
        string scoretext = InputScore();
        int scoreDecimal = ConvertStringToInt(scoretext);
        string grade = ConvertScoreToGrade(scoreDecimal);

        PrintInputInformation(name,scoretext,grade);
    }
}
