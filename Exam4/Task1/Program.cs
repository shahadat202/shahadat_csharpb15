
long byteSize = 5L * 1024 * 1024 * 1024;
long fileSize = byteSize / 4;

string path = "../../../../text.txt";
if (!File.Exists(path))
    File.Create(path);

GenerateFile(path, fileSize);

static void GenerateFile(string path, long fileSize)
{
    
}


Random random = new Random(DateTime.Now.Millisecond);

for(int i = 0; i < 50; i++)
{
    Console.Write(GetRandomChar());
}

char GetRandomChar()
{
    return (char)random.Next('A', 'Z');
}