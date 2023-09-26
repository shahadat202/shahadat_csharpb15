
string name = "tareq";

name = "jalaluddin";
Console.WriteLine(name);

string[] names = new string[20];
names[0] = "tareq";
names[1] = "hasan";

int[] ages = new [] 
{ 
    20, 
    30 
};

int[,] grid = new int[,]
{
    { 2, 3, 4},
    { 4, 5, 9 }
};

grid[0, 1] = 3;

int item = grid[2, 2];


int[][] scores = new int[3][];
scores[0] = new int[2];
scores[1] = new int[3];
scores[2] = new int[6];

scores[0][1] = 5;

int[][][] x = new int[3][][];
x[0] = new int[3][];
x[0][0] = new int[4];
x[0][0][1] = 3;

int[][] something = new int[][]
{
    new []{ 2, 3},
    new []{ 4, 5, 6},
    new []{ 3, 9 }
};


for(int i = 0; i < something.GetLength(0); i++)
{
    for(int j = 0; j < something[i].GetLength(i); j++)
    {

    }
}

