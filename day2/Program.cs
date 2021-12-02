var lines = File.ReadAllLines("input.txt");

(int x, int y) coords = (0, 0);
int aim = 0;

foreach (var line in lines)
{
    var values = line.Split(' ');

    var direction = values[0];
    var amount = int.Parse(values[1]);

    switch (direction)
    {
        case "forward":
            coords.x += amount;
            coords.y += amount * aim;
            break;
        case "down":
            aim += amount;
            break;
        case "up":
            aim -= amount;
            break;
    }
}

Console.WriteLine(coords.x * coords.y);