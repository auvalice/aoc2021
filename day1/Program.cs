using System.IO;

var lines = File.ReadAllLines("input.txt");

int count = 0;

for (int index = 3; index < lines.Length; index++)
{
    /*
        When checking the sum of the first three numbers and the last three numbers,
        the second and third numbers do not vary. We only need to check if the fourth
        number is larger or not than the first.
     */

    int a = int.Parse(lines[index - 3]);
    // int b = int.Parse(lines[index - 2]);
    // int c = int.Parse(lines[index - 1]);
    int d = int.Parse(lines[index]);

    if(d > a) {
        count++;
    }    

}

Console.WriteLine(count);