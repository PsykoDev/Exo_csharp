namespace DefaultNamespace
{
    public class Variables
    {
        var a = 1; // variable qui peux prendre n'importe quel type de donnée
        const int b = 2; // variable de type entier constante
        int c = 3; // variable de type entier
        float d = 4.5f; // variable de type flottant
        double e = 5.5; // variable de type flottant
        string f = "Hello World"; // variable de type chaîne de caractères
        bool g = true; // variable de type booléen
        char h = 'a'; // variable de type caractère
        object i = new object(); // variable de type objet
        object[] j = new object[3]; // variable de type tableau d'objets
        int[] k = new int[3]; // variable de type tableau d'entiers
        float[] l = new float[3]; // variable de type tableau de flottants
        double[] m = new double[3]; // variable de type tableau de flottants
        string[] n = new string[3]; // variable de type tableau de chaînes de caractères
        bool[] o = new bool[3]; // variable de type tableau de booléens
        char[] p = new char[3]; // variable de type tableau de caractères
        object[,] q = new object[3, 3]; // variable de type tableau de tableaux d'objets
        int[,] r = new int[3, 3]; // variable de type tableau de tableaux d'entiers
        float[,] s = new float[3, 3]; // variable de type tableau de tableaux de flottants
        double[,] t = new double[3, 3]; // variable de type tableau de tableaux de flottants
        string[,] u = new string[3, 3]; // variable de type tableau de tableaux de chaînes de caractères
        bool[,] v = new bool[3, 3]; // variable de type tableau de tableaux de booléens
        List<string> list = new List<string>(); // variable de type liste de chaînes de caractères
        Dictionary<string, int> dict = new Dictionary<string, int>(); // variable de type dictionnaire de chaînes de caractères et entiers

        // et bien plus 
        // https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/
    }
}
